using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1061_PICHERMAYER_RUXANDRA
{
    public partial class FormEditeaza : MaterialForm
    {
        public string numeV { get; set; }
        public decimal suma { get; set; }
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public FormEditeaza()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink700,
                MaterialSkin.Primary.Pink900, MaterialSkin.Primary.LightGreen500, MaterialSkin.Accent.LightGreen200,
                MaterialSkin.TextShade.WHITE);

            TextBoxNumeVEdit.ForeColor = Color.Black;
            TextBoxNumeVEdit.BackColor = Color.White; 

            TextBoxSumaEdit.ForeColor = Color.Black;
            TextBoxSumaEdit.BackColor = Color.White; 

            LabelValutaEdit.ForeColor = Color.Black;
            LabelTip.ForeColor = Color.Black;

 
            this.BackColor = Color.WhiteSmoke;

            TextBoxNumeVEdit.Focus();
        }

        private void ButtonEfEdit_Click(object sender, EventArgs e)
        {
            numeV = TextBoxNumeVEdit.Text;
            string textSuma = TextBoxSumaEdit.Text;

            if (decimal.TryParse(textSuma, out decimal sum))
            {
                suma = sum;
            }
            else
            {
                MessageBox.Show("Textul introdus nu este un număr valid.", "Eroare de conversie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void FormEditeaza_Load(object sender, EventArgs e)
        {
            TextBoxNumeVEdit.Focus();
        }

        private void LabelTip_Click(object sender, EventArgs e)
        {

        }
    }
}
