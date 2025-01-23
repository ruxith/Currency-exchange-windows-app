namespace _2_1061_PICHERMAYER_RUXANDRA
{
    partial class FormEditeaza
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
            this.TextBoxSumaEdit = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxNumeVEdit = new MaterialSkin.Controls.MaterialTextBox();
            this.LabelValutaEdit = new MaterialSkin.Controls.MaterialLabel();
            this.LabelTip = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonEfEdit = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // TextBoxSumaEdit
            // 
            this.TextBoxSumaEdit.AnimateReadOnly = false;
            this.TextBoxSumaEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSumaEdit.Depth = 0;
            this.TextBoxSumaEdit.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxSumaEdit.LeadingIcon = null;
            this.TextBoxSumaEdit.Location = new System.Drawing.Point(33, 182);
            this.TextBoxSumaEdit.MaxLength = 50;
            this.TextBoxSumaEdit.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxSumaEdit.Multiline = false;
            this.TextBoxSumaEdit.Name = "TextBoxSumaEdit";
            this.TextBoxSumaEdit.Size = new System.Drawing.Size(273, 50);
            this.TextBoxSumaEdit.TabIndex = 0;
            this.TextBoxSumaEdit.Text = "";
            this.TextBoxSumaEdit.TrailingIcon = null;
            // 
            // TextBoxNumeVEdit
            // 
            this.TextBoxNumeVEdit.AnimateReadOnly = false;
            this.TextBoxNumeVEdit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBoxNumeVEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxNumeVEdit.Depth = 0;
            this.TextBoxNumeVEdit.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxNumeVEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxNumeVEdit.LeadingIcon = null;
            this.TextBoxNumeVEdit.Location = new System.Drawing.Point(33, 96);
            this.TextBoxNumeVEdit.MaxLength = 50;
            this.TextBoxNumeVEdit.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxNumeVEdit.Multiline = false;
            this.TextBoxNumeVEdit.Name = "TextBoxNumeVEdit";
            this.TextBoxNumeVEdit.Size = new System.Drawing.Size(273, 50);
            this.TextBoxNumeVEdit.TabIndex = 3;
            this.TextBoxNumeVEdit.Text = "";
            this.TextBoxNumeVEdit.TrailingIcon = null;
            // 
            // LabelValutaEdit
            // 
            this.LabelValutaEdit.AutoSize = true;
            this.LabelValutaEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelValutaEdit.Depth = 0;
            this.LabelValutaEdit.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelValutaEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelValutaEdit.Location = new System.Drawing.Point(30, 74);
            this.LabelValutaEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelValutaEdit.Name = "LabelValutaEdit";
            this.LabelValutaEdit.Size = new System.Drawing.Size(95, 19);
            this.LabelValutaEdit.TabIndex = 4;
            this.LabelValutaEdit.Text = "Nume valuta:";
            // 
            // LabelTip
            // 
            this.LabelTip.AutoSize = true;
            this.LabelTip.Depth = 0;
            this.LabelTip.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelTip.Location = new System.Drawing.Point(30, 160);
            this.LabelTip.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelTip.Name = "LabelTip";
            this.LabelTip.Size = new System.Drawing.Size(47, 19);
            this.LabelTip.TabIndex = 7;
            this.LabelTip.Text = "Suma:";
            this.LabelTip.Click += new System.EventHandler(this.LabelTip_Click);
            // 
            // ButtonEfEdit
            // 
            this.ButtonEfEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonEfEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonEfEdit.Depth = 0;
            this.ButtonEfEdit.HighEmphasis = true;
            this.ButtonEfEdit.Icon = null;
            this.ButtonEfEdit.Location = new System.Drawing.Point(204, 249);
            this.ButtonEfEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonEfEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonEfEdit.Name = "ButtonEfEdit";
            this.ButtonEfEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonEfEdit.Size = new System.Drawing.Size(102, 36);
            this.ButtonEfEdit.TabIndex = 8;
            this.ButtonEfEdit.Text = "Efectuare";
            this.ButtonEfEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonEfEdit.UseAccentColor = false;
            this.ButtonEfEdit.UseVisualStyleBackColor = true;
            this.ButtonEfEdit.Click += new System.EventHandler(this.ButtonEfEdit_Click);
            // 
            // FormEditeaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(370, 294);
            this.Controls.Add(this.ButtonEfEdit);
            this.Controls.Add(this.LabelTip);
            this.Controls.Add(this.LabelValutaEdit);
            this.Controls.Add(this.TextBoxNumeVEdit);
            this.Controls.Add(this.TextBoxSumaEdit);
            this.Name = "FormEditeaza";
            this.Text = "Editeaza tranzactie";
            this.Load += new System.EventHandler(this.FormEditeaza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox TextBoxSumaEdit;
        private MaterialSkin.Controls.MaterialTextBox TextBoxNumeVEdit;
        private MaterialSkin.Controls.MaterialLabel LabelValutaEdit;
        private MaterialSkin.Controls.MaterialLabel LabelTip;
        private MaterialSkin.Controls.MaterialButton ButtonEfEdit;
    }
}