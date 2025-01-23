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
    public partial class AdaugareValuta : MaterialForm
    {
        public string Nume;
        public string cod;
        public decimal minim;
        public decimal maxim;
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public AdaugareValuta()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Pink700,
                MaterialSkin.Primary.Pink900, MaterialSkin.Primary.LightGreen500, MaterialSkin.Accent.LightGreen200,
                MaterialSkin.TextShade.WHITE);

            TextBoxCod.ForeColor = Color.Black;
            TextBoxCod.BackColor = Color.White;

            TextBoxMax.ForeColor = Color.Black;
            TextBoxMax.BackColor = Color.White;

            TextBoxMin.ForeColor = Color.Black;
            TextBoxMin.BackColor = Color.White;

            TextBoxNume.ForeColor = Color.Black;
            TextBoxNume.BackColor = Color.White;

            this.BackColor = Color.WhiteSmoke;

            materialLabel1.ForeColor = Color.Black;
            materialLabel2.ForeColor = Color.Black;
            materialLabel3.ForeColor = Color.Black;
            materialLabel4.ForeColor = Color.Black;
        }

        private void AdaugareValuta_Load(object sender, EventArgs e)
        {
            TextBoxNume.Focus();
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonEfValuta_Click(object sender, EventArgs e)
        {
            Nume = TextBoxNume.Text;
            cod = TextBoxCod.Text;
            minim = decimal.Parse(TextBoxMin.Text);
            maxim = decimal.Parse(TextBoxMax.Text);

            this.Close();
        }
    }
}
