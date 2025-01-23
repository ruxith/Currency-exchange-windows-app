namespace _2_1061_PICHERMAYER_RUXANDRA
{
    partial class AdaugareValuta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonEfValuta = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxCod = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxNume = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxMin = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxMax = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // ButtonEfValuta
            // 
            this.ButtonEfValuta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonEfValuta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonEfValuta.Depth = 0;
            this.ButtonEfValuta.HighEmphasis = true;
            this.ButtonEfValuta.Icon = null;
            this.ButtonEfValuta.Location = new System.Drawing.Point(460, 288);
            this.ButtonEfValuta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonEfValuta.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonEfValuta.Name = "ButtonEfValuta";
            this.ButtonEfValuta.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonEfValuta.Size = new System.Drawing.Size(102, 36);
            this.ButtonEfValuta.TabIndex = 0;
            this.ButtonEfValuta.Text = "Efectuare";
            this.ButtonEfValuta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonEfValuta.UseAccentColor = false;
            this.ButtonEfValuta.UseVisualStyleBackColor = true;
            this.ButtonEfValuta.Click += new System.EventHandler(this.ButtonEfValuta_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(35, 196);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(33, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Cod:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(35, 105);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(95, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Nume valuta:";
            // 
            // TextBoxCod
            // 
            this.TextBoxCod.AnimateReadOnly = false;
            this.TextBoxCod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxCod.Depth = 0;
            this.TextBoxCod.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxCod.LeadingIcon = null;
            this.TextBoxCod.Location = new System.Drawing.Point(38, 218);
            this.TextBoxCod.MaxLength = 50;
            this.TextBoxCod.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxCod.Multiline = false;
            this.TextBoxCod.Name = "TextBoxCod";
            this.TextBoxCod.Size = new System.Drawing.Size(247, 50);
            this.TextBoxCod.TabIndex = 3;
            this.TextBoxCod.Text = "";
            this.TextBoxCod.TrailingIcon = null;
            this.TextBoxCod.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // TextBoxNume
            // 
            this.TextBoxNume.AnimateReadOnly = false;
            this.TextBoxNume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxNume.Depth = 0;
            this.TextBoxNume.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxNume.LeadingIcon = null;
            this.TextBoxNume.Location = new System.Drawing.Point(38, 127);
            this.TextBoxNume.MaxLength = 50;
            this.TextBoxNume.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxNume.Multiline = false;
            this.TextBoxNume.Name = "TextBoxNume";
            this.TextBoxNume.Size = new System.Drawing.Size(247, 50);
            this.TextBoxNume.TabIndex = 4;
            this.TextBoxNume.Text = "";
            this.TextBoxNume.TrailingIcon = null;
            // 
            // TextBoxMin
            // 
            this.TextBoxMin.AnimateReadOnly = false;
            this.TextBoxMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMin.Depth = 0;
            this.TextBoxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxMin.LeadingIcon = null;
            this.TextBoxMin.Location = new System.Drawing.Point(315, 127);
            this.TextBoxMin.MaxLength = 50;
            this.TextBoxMin.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxMin.Multiline = false;
            this.TextBoxMin.Name = "TextBoxMin";
            this.TextBoxMin.Size = new System.Drawing.Size(247, 50);
            this.TextBoxMin.TabIndex = 8;
            this.TextBoxMin.Text = "";
            this.TextBoxMin.TrailingIcon = null;
            // 
            // TextBoxMax
            // 
            this.TextBoxMax.AnimateReadOnly = false;
            this.TextBoxMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMax.Depth = 0;
            this.TextBoxMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxMax.LeadingIcon = null;
            this.TextBoxMax.Location = new System.Drawing.Point(315, 218);
            this.TextBoxMax.MaxLength = 50;
            this.TextBoxMax.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxMax.Multiline = false;
            this.TextBoxMax.Name = "TextBoxMax";
            this.TextBoxMax.Size = new System.Drawing.Size(247, 50);
            this.TextBoxMax.TabIndex = 7;
            this.TextBoxMax.Text = "";
            this.TextBoxMax.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(312, 105);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(63, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Minimul:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(312, 196);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(67, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Maximul:";
            // 
            // AdaugareValuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 369);
            this.Controls.Add(this.TextBoxMin);
            this.Controls.Add(this.TextBoxMax);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.TextBoxNume);
            this.Controls.Add(this.TextBoxCod);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ButtonEfValuta);
            this.Name = "AdaugareValuta";
            this.Text = "Adaugare Valuta";
            this.Load += new System.EventHandler(this.AdaugareValuta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton ButtonEfValuta;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox TextBoxCod;
        private MaterialSkin.Controls.MaterialTextBox TextBoxNume;
        private MaterialSkin.Controls.MaterialTextBox TextBoxMin;
        private MaterialSkin.Controls.MaterialTextBox TextBoxMax;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}