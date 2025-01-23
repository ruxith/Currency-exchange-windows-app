using _2_1061_PICHERMAYER_RUXANDRA.BazaDate;
using _2_1061_PICHERMAYER_RUXANDRA.Entities;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1061_PICHERMAYER_RUXANDRA
{
    public partial class FormPrincipal : MaterialForm
    {
        private static readonly Random random = new Random();
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        DataRepository dataRepository = new DataRepository();
        DataBase dataBase = new DataBase();

        AdaugareValuta FormAdaugaV = new AdaugareValuta();
        FormEditeaza formEditeaza = new FormEditeaza();

        public FormPrincipal()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink700,
                MaterialSkin.Primary.Pink900, MaterialSkin.Primary.LightGreen500, MaterialSkin.Accent.LightGreen200,
                MaterialSkin.TextShade.BLACK);


            //ADAUGAREA DATELOR DIN BAZA DE DATE
            dataRepository.Valuta = dataBase.GetAllValute();

            dataRepository.CursuriValutare = dataBase.GetAllCursValutar();

            dataRepository.Tranzactii = dataBase.GetTranzactii();

            
            initializeDataGridViewValute();
            CreateButtonColumn("Delete product", "Delete", "DeleteColumn", dataGridViewValute);
            CreateButtonColumn("Edit product", "Edit", "EditColumn", dataGridViewValute);

            //PENTRU CURSUL VALUTAR DIN ZIUA CURENTA
            List<CursuriValutare> cursulZilei = generareCursValutarAzi();
            initializeDataGridViewCursulZilei(cursulZilei);

            ConvertorValutar();

        }

        public void ConvertorValutar()
        {
            BindingList<string> numeValute = new BindingList<string>();
            BindingList<string> leu = new BindingList<string>();
            leu.Add("Leu Românesc");
            foreach (var val in dataRepository.Valuta)
            {
                if (val.Nume != "Leu Românesc")
                {
                    numeValute.Add(val.Nume);

                }
            }
            UpdateComboBoxDataSources(numeValute, leu);
            SwitchCumpar.CheckedChanged += (sender, e) => UpdateComboBoxDataSources(numeValute, leu);
        }
        public static decimal GenerateRandomCurs(decimal minValue, decimal maxValue)
        {
            double doubleMin = (double)minValue;
            double doubleMax = (double)maxValue;

            double scaled = (random.NextDouble() * (doubleMax - doubleMin)) + doubleMin;

            return (decimal)scaled;
        }
        private List<CursuriValutare> generareCursValutarAzi()
        {
            LabelData.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            List<CursuriValutare> cursulZilei = new List<CursuriValutare>();

            if (dataRepository.CursuriValutare.Find(x => x.DataCursului == DateTime.Now.Date) != null)
            {
                cursulZilei = dataRepository.CursuriValutare
                    .Where(x => x.DataCursului == DateTime.Now.Date).ToList();
            }
            else
            {
                foreach (var val in dataRepository.Valuta)
                {
                    decimal cump = GenerateRandomCurs(val.Minim, val.Maxim);
                    decimal vanz = GenerateRandomCurs(val.Minim, val.Maxim);
                    CursuriValutare curs = new CursuriValutare(val.ID, val.Nume, DateTime.Now.Date, cump, vanz);
                    cursulZilei.Add(curs);
                    dataBase.AddCursValutar(curs);
                    dataRepository.CursuriValutare.Add(curs);
                }
            }
            return cursulZilei;
        }
        private void initializeDataGridViewValute()
        {
            dataGridViewValute.AutoGenerateColumns = true;
            dataGridViewValute.DataSource = dataRepository.Valuta;

            dataGridViewCursulZilei.RightToLeft = RightToLeft.No;
            dataGridViewValute.Columns["ID"].Visible = false;
            
            dataGridViewCursulZilei.Refresh();
            
        }

        private void initializeDataGridViewCursulZilei(List<CursuriValutare> cursulZilei)
        {
            dataGridViewCursulZilei.AutoGenerateColumns = true;
            dataGridViewCursulZilei.DataSource = cursulZilei;
            dataGridViewCursulZilei.RightToLeft = RightToLeft.No;
            HideUnwantedColumns(dataGridViewCursulZilei);
            dataGridViewCursulZilei.Refresh();
        }

        private string GetIdValuta(string nume)
        {
            foreach (var val in dataRepository.Valuta)
            {
                if (nume.ToUpper() == val.Cod.ToUpper())
                {
                    return val.ID;
                }
            }
            return null;
        }
        private void CreateButtonColumn(string headerText, string buttonText, string columnName, DataGridView dataGrid)
        {
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.HeaderText = headerText;
            column.Text = buttonText;
            column.UseColumnTextForButtonValue = true;
            column.Name = columnName;

            dataGrid.Columns.Add(column);
        }
        private void HideUnwantedColumns(DataGridView dataGridView)
        {
            dataGridView.Columns["IDValuta"].Visible = false;
            dataGridView.Columns["ID"].Visible = false;
        }
        private void UpdateComboBoxDataSources(BindingList<string> numeValute, BindingList<string> leu)
        {
            if (SwitchCumpar.Checked)
            {
                ComboBoxSuma.DataSource = numeValute;
                ComboBoxPrimesc.DataSource = leu;
            }
            else
            {

                ComboBoxSuma.DataSource = leu;
                ComboBoxPrimesc.DataSource = numeValute;
            }
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void SwitchCumpar_CheckedChanged(object sender, EventArgs e)
        {
            if (SwitchCumpar.Checked)
            {
                SwitchCumpar.Text = "Vând";
                SwitchCumpar.ForeColor = Color.LightGreen;
            }
            else
            {
                SwitchCumpar.Text = "Cumpăr";
                SwitchCumpar.ForeColor = Color.DarkGreen;
            }
        }
        //BUTTON CAUTARE TRANZACTII
        private void materialButton1_Click(object sender, EventArgs e)
        {
            DateTime data = dateTimePickerTranzactii.Value;
            BindingList<Tranzactii> tranzactii = dataBase.GetTranzactii(data);

            dataGridViewTranzactii.AutoGenerateColumns = true;

            CreateButtonColumn("Delete product", "Delete", "DeleteColumn", dataGridViewTranzactii);
            CreateButtonColumn("Edit product", "Edit", "EditColumn", dataGridViewTranzactii);

            dataGridViewTranzactii.RightToLeft = RightToLeft.No;
            dataGridViewTranzactii.DataSource = tranzactii;
            HideUnwantedColumns(dataGridViewTranzactii);
            dataGridViewTranzactii.Refresh();
            
        }

        
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonAfiseaza_Click(object sender, EventArgs e)
        {
            DateTime data = dateTimePickerCurs.Value;
            BindingList<CursuriValutare> cursuri = dataBase.GetCursValutar(data);

            dataGridViewCursuri.AutoGenerateColumns = true;
            dataGridViewCursuri.RightToLeft = RightToLeft.No;
            dataGridViewTranzactii.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewTranzactii.DefaultCellStyle.BackColor = Color.White;
            dataGridViewCursuri.DataSource = cursuri;
            HideUnwantedColumns(dataGridViewCursuri);
            dataGridViewCursuri.Refresh();
        }


        private void ButtonSuma_Click(object sender, EventArgs e)
        {
            decimal suma = decimal.Parse(TextBoxSuma.Text);
            List<CursuriValutare> cursulZilei = generareCursValutarAzi();
            string numeValutaCump = ComboBoxPrimesc.SelectedItem.ToString();
            string numeValutaVand = ComboBoxSuma.SelectedItem.ToString();
            if (SwitchCumpar.Checked)
            {

                CursuriValutare curs = cursulZilei.Find(v => v.NumeValuta == numeValutaVand);
                if (curs == null)
                {
                    MessageBox.Show("Momentan aceasta moneda nu este disponibila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    suma *= curs.CursVanzare;
                    TextBoxPrimesc.Text = suma.ToString();
                }

            }
            else
            {
                CursuriValutare curs = cursulZilei.Find(v => v.NumeValuta == numeValutaCump);
                if (curs == null)
                {
                    MessageBox.Show("Momentan aceasta moneda nu este disponibila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    suma /= curs.CursCumparare;
                    TextBoxPrimesc.Text = suma.ToString();
                }

            }
        }

        private void ButtonTranzactieEf_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxPrimesc.Text))
            {
                string numeValuta = ComboBoxPrimesc.SelectedItem.ToString();
                Guid idGuid = Guid.NewGuid();
                string id = idGuid.ToString();
                string IdValuta = (dataRepository.Valuta.FirstOrDefault(v => v.Nume == numeValuta)).ID;
                string tip;
                if (SwitchCumpar.Checked)
                {
                    tip = "Vanzare";
                }
                else
                {
                    tip = "Cumparare";
                }
                Tranzactii tranzactie = new Tranzactii(id, IdValuta, numeValuta, decimal.Parse(TextBoxPrimesc.Text), DateTime.Now.Date, tip);
                dataRepository.Tranzactii.Add(tranzactie);
                dataBase.AddTranzactie(tranzactie);

                MessageBox.Show("Tranzactie efectuata cu success.");

                TextBoxPrimesc.Clear();
                TextBoxSuma.Clear();
                ButtonTranzactieEf.Refresh();
                this.ActiveControl = null;
            }
            else
            {
                MessageBox.Show("Faceti mai intai un schimb valutar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewTranzactii_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            var columnName = grid.Columns[e.ColumnIndex].Name;

            var tranzactie = (Tranzactii)grid.Rows[e.RowIndex].DataBoundItem;

            if (columnName == "DeleteColumn")
            {
                var result = MessageBox.Show($"Are you sure you want to delete {tranzactie.ID}?",
                    "Please confirm your action",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    foreach(var tranz in dataRepository.Tranzactii)
                    {
                        if(tranz.ID == tranzactie.ID)
                        {
                            dataRepository.deleteTranzactie(tranz);
                            break;
                        }
                    }
                    
                    dataBase.DeleteTranzactie(tranzactie.ID);
                    grid.DataSource = null;

                    DateTime data = dateTimePickerTranzactii.Value;
                    BindingList<Tranzactii> tranzactii = dataBase.GetTranzactii(data);

                    dataGridViewTranzactii.AutoGenerateColumns = true;
                    dataGridViewTranzactii.RightToLeft = RightToLeft.No;
                    dataGridViewTranzactii.DataSource = tranzactii;
                    HideUnwantedColumns(dataGridViewTranzactii);
                    dataGridViewTranzactii.Refresh();
                    grid.Refresh();
                }

            }
            if (columnName == "EditColumn")
            {
                formEditeaza.ShowDialog();
                string idValuta = GetIdValuta(formEditeaza.numeV);

                if (idValuta != null)
                {
                    foreach(var tranz in dataRepository.Tranzactii)
                    {
                        if(tranz.ID == tranzactie.ID)
                        {
                            tranz.IDValuta = idValuta;
                            tranz.NumeValuta = formEditeaza.numeV.ToUpper();
                            tranz.Suma = formEditeaza.suma;
                        }
                    }
                    tranzactie.IDValuta = idValuta;
                    tranzactie.NumeValuta = formEditeaza.numeV.ToUpper();
                    tranzactie.Suma = formEditeaza.suma;
                    dataBase.EditTranzactie(tranzactie);

                    grid.Refresh();
                }
                else
                {
                    MessageBox.Show("Momentan aceasta moneda nu este disponibila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            var columnName = grid.Columns[e.ColumnIndex].Name;

            var valuta = (Valuta)grid.Rows[e.RowIndex].DataBoundItem;

            if (columnName == "DeleteColumn")
            {
                var result = MessageBox.Show($"Are you sure you want to delete {valuta.Nume}?",
                    "Please confirm your action",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    foreach (var val in dataRepository.Valuta)
                    {
                        if (val.ID == valuta.ID)
                        {
                            dataRepository.deleteValuta(val);
                            break;
                        }
                    }

                    dataBase.DeleteValuta(valuta.ID);
                    grid.DataSource = null;

                    initializeDataGridViewValute();
                    grid.Refresh();
                }

            }
            if (columnName == "EditColumn")
            {
                
                MessageBox.Show("Momentan aceasta functie nu este disponibila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void ButtonAdaugaValuta_Click(object sender, EventArgs e)
        {
            FormAdaugaV.ShowDialog(); 

            if(FormAdaugaV.cod != null)
            {
                if (dataRepository.Valuta.Find(x => x.Cod == FormAdaugaV.cod) != null)
                {
                    MessageBox.Show("Valuta existenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Valuta valutaNoua = new Valuta(FormAdaugaV.Nume, FormAdaugaV.cod, FormAdaugaV.minim, FormAdaugaV.maxim);

                    dataRepository.Valuta.Add(valutaNoua);
                    dataBase.AddValuta(valutaNoua);
                    this.ActiveControl = null;

                    dataGridViewValute.DataSource = null;
                    initializeDataGridViewValute();
                }
            }
        }
    }
}
