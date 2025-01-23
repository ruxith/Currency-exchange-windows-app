namespace _2_1061_PICHERMAYER_RUXANDRA
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageCursValutar = new System.Windows.Forms.TabPage();
            this.dataGridViewCursulZilei = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LabelData = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageConvertor = new System.Windows.Forms.TabPage();
            this.ComboBoxSuma = new MaterialSkin.Controls.MaterialComboBox();
            this.ButtonSuma = new MaterialSkin.Controls.MaterialButton();
            this.ButtonTranzactieEf = new MaterialSkin.Controls.MaterialButton();
            this.TextBoxPrimesc = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.SwitchCumpar = new MaterialSkin.Controls.MaterialSwitch();
            this.TextBoxSuma = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.ComboBoxPrimesc = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TabPageTranzactii = new System.Windows.Forms.TabPage();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePickerTranzactii = new System.Windows.Forms.DateTimePicker();
            this.ButtonCautare = new MaterialSkin.Controls.MaterialButton();
            this.dataGridViewTranzactii = new System.Windows.Forms.DataGridView();
            this.tabPageistoric = new System.Windows.Forms.TabPage();
            this.ButtonAfiseaza = new MaterialSkin.Controls.MaterialButton();
            this.dateTimePickerCurs = new System.Windows.Forms.DateTimePicker();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridViewCursuri = new System.Windows.Forms.DataGridView();
            this.tabValute = new System.Windows.Forms.TabPage();
            this.ButtonAdaugaValuta = new MaterialSkin.Controls.MaterialButton();
            this.dataGridViewValute = new System.Windows.Forms.DataGridView();
            this.materialTabControl1.SuspendLayout();
            this.tabPageCursValutar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursulZilei)).BeginInit();
            this.tabPageConvertor.SuspendLayout();
            this.TabPageTranzactii.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTranzactii)).BeginInit();
            this.tabPageistoric.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursuri)).BeginInit();
            this.tabValute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValute)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageCursValutar);
            this.materialTabControl1.Controls.Add(this.tabPageConvertor);
            this.materialTabControl1.Controls.Add(this.TabPageTranzactii);
            this.materialTabControl1.Controls.Add(this.tabPageistoric);
            this.materialTabControl1.Controls.Add(this.tabValute);
            this.materialTabControl1.Depth = 0;
            resources.ApplyResources(this.materialTabControl1, "materialTabControl1");
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            // 
            // tabPageCursValutar
            // 
            this.tabPageCursValutar.BackColor = System.Drawing.Color.White;
            this.tabPageCursValutar.Controls.Add(this.dataGridViewCursulZilei);
            this.tabPageCursValutar.Controls.Add(this.materialLabel1);
            this.tabPageCursValutar.Controls.Add(this.LabelData);
            resources.ApplyResources(this.tabPageCursValutar, "tabPageCursValutar");
            this.tabPageCursValutar.Name = "tabPageCursValutar";
            // 
            // dataGridViewCursulZilei
            // 
            this.dataGridViewCursulZilei.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCursulZilei.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridViewCursulZilei, "dataGridViewCursulZilei");
            this.dataGridViewCursulZilei.Name = "dataGridViewCursulZilei";
            this.dataGridViewCursulZilei.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // LabelData
            // 
            resources.ApplyResources(this.LabelData, "LabelData");
            this.LabelData.Depth = 0;
            this.LabelData.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelData.Name = "LabelData";
            // 
            // tabPageConvertor
            // 
            this.tabPageConvertor.AllowDrop = true;
            this.tabPageConvertor.BackColor = System.Drawing.Color.White;
            this.tabPageConvertor.Controls.Add(this.ComboBoxSuma);
            this.tabPageConvertor.Controls.Add(this.ButtonSuma);
            this.tabPageConvertor.Controls.Add(this.ButtonTranzactieEf);
            this.tabPageConvertor.Controls.Add(this.TextBoxPrimesc);
            this.tabPageConvertor.Controls.Add(this.SwitchCumpar);
            this.tabPageConvertor.Controls.Add(this.TextBoxSuma);
            this.tabPageConvertor.Controls.Add(this.ComboBoxPrimesc);
            this.tabPageConvertor.Controls.Add(this.materialLabel4);
            this.tabPageConvertor.Controls.Add(this.materialLabel3);
            resources.ApplyResources(this.tabPageConvertor, "tabPageConvertor");
            this.tabPageConvertor.Name = "tabPageConvertor";
            // 
            // ComboBoxSuma
            // 
            this.ComboBoxSuma.AutoResize = false;
            this.ComboBoxSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxSuma.Depth = 0;
            this.ComboBoxSuma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxSuma.DropDownHeight = 174;
            this.ComboBoxSuma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSuma.DropDownWidth = 121;
            resources.ApplyResources(this.ComboBoxSuma, "ComboBoxSuma");
            this.ComboBoxSuma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxSuma.FormattingEnabled = true;
            this.ComboBoxSuma.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxSuma.Name = "ComboBoxSuma";
            this.ComboBoxSuma.StartIndex = 0;
            // 
            // ButtonSuma
            // 
            resources.ApplyResources(this.ButtonSuma, "ButtonSuma");
            this.ButtonSuma.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonSuma.Depth = 0;
            this.ButtonSuma.DialogResult = System.Windows.Forms.DialogResult.No;
            this.ButtonSuma.HighEmphasis = true;
            this.ButtonSuma.Icon = null;
            this.ButtonSuma.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSuma.Name = "ButtonSuma";
            this.ButtonSuma.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonSuma.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonSuma.UseAccentColor = false;
            this.ButtonSuma.UseVisualStyleBackColor = true;
            this.ButtonSuma.Click += new System.EventHandler(this.ButtonSuma_Click);
            // 
            // ButtonTranzactieEf
            // 
            resources.ApplyResources(this.ButtonTranzactieEf, "ButtonTranzactieEf");
            this.ButtonTranzactieEf.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonTranzactieEf.Depth = 0;
            this.ButtonTranzactieEf.HighEmphasis = true;
            this.ButtonTranzactieEf.Icon = null;
            this.ButtonTranzactieEf.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonTranzactieEf.Name = "ButtonTranzactieEf";
            this.ButtonTranzactieEf.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonTranzactieEf.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonTranzactieEf.UseAccentColor = false;
            this.ButtonTranzactieEf.UseVisualStyleBackColor = true;
            this.ButtonTranzactieEf.Click += new System.EventHandler(this.ButtonTranzactieEf_Click);
            // 
            // TextBoxPrimesc
            // 
            this.TextBoxPrimesc.AllowPromptAsInput = true;
            this.TextBoxPrimesc.AnimateReadOnly = false;
            this.TextBoxPrimesc.AsciiOnly = true;
            resources.ApplyResources(this.TextBoxPrimesc, "TextBoxPrimesc");
            this.TextBoxPrimesc.BeepOnError = false;
            this.TextBoxPrimesc.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextBoxPrimesc.Depth = 0;
            this.TextBoxPrimesc.HidePromptOnLeave = false;
            this.TextBoxPrimesc.HideSelection = true;
            this.TextBoxPrimesc.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.TextBoxPrimesc.LeadingIcon = null;
            this.TextBoxPrimesc.Mask = "";
            this.TextBoxPrimesc.MaxLength = 32767;
            this.TextBoxPrimesc.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxPrimesc.Name = "TextBoxPrimesc";
            this.TextBoxPrimesc.PasswordChar = '\0';
            this.TextBoxPrimesc.PromptChar = '_';
            this.TextBoxPrimesc.ReadOnly = false;
            this.TextBoxPrimesc.RejectInputOnFirstFailure = false;
            this.TextBoxPrimesc.ResetOnPrompt = true;
            this.TextBoxPrimesc.ResetOnSpace = true;
            this.TextBoxPrimesc.SelectedText = "";
            this.TextBoxPrimesc.SelectionLength = 0;
            this.TextBoxPrimesc.SelectionStart = 0;
            this.TextBoxPrimesc.ShortcutsEnabled = true;
            this.TextBoxPrimesc.SkipLiterals = false;
            this.TextBoxPrimesc.TabStop = false;
            this.TextBoxPrimesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxPrimesc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextBoxPrimesc.TrailingIcon = null;
            this.TextBoxPrimesc.UseSystemPasswordChar = false;
            this.TextBoxPrimesc.ValidatingType = null;
            // 
            // SwitchCumpar
            // 
            resources.ApplyResources(this.SwitchCumpar, "SwitchCumpar");
            this.SwitchCumpar.Depth = 0;
            this.SwitchCumpar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SwitchCumpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwitchCumpar.Name = "SwitchCumpar";
            this.SwitchCumpar.Ripple = true;
            this.SwitchCumpar.UseVisualStyleBackColor = true;
            this.SwitchCumpar.CheckedChanged += new System.EventHandler(this.SwitchCumpar_CheckedChanged);
            // 
            // TextBoxSuma
            // 
            this.TextBoxSuma.AllowPromptAsInput = true;
            this.TextBoxSuma.AnimateReadOnly = false;
            this.TextBoxSuma.AsciiOnly = false;
            resources.ApplyResources(this.TextBoxSuma, "TextBoxSuma");
            this.TextBoxSuma.BeepOnError = false;
            this.TextBoxSuma.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextBoxSuma.Depth = 0;
            this.TextBoxSuma.HidePromptOnLeave = false;
            this.TextBoxSuma.HideSelection = true;
            this.TextBoxSuma.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.TextBoxSuma.LeadingIcon = null;
            this.TextBoxSuma.Mask = "";
            this.TextBoxSuma.MaxLength = 32767;
            this.TextBoxSuma.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxSuma.Name = "TextBoxSuma";
            this.TextBoxSuma.PasswordChar = '\0';
            this.TextBoxSuma.PromptChar = '_';
            this.TextBoxSuma.ReadOnly = false;
            this.TextBoxSuma.RejectInputOnFirstFailure = false;
            this.TextBoxSuma.ResetOnPrompt = true;
            this.TextBoxSuma.ResetOnSpace = true;
            this.TextBoxSuma.SelectedText = "";
            this.TextBoxSuma.SelectionLength = 0;
            this.TextBoxSuma.SelectionStart = 0;
            this.TextBoxSuma.ShortcutsEnabled = true;
            this.TextBoxSuma.SkipLiterals = true;
            this.TextBoxSuma.TabStop = false;
            this.TextBoxSuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxSuma.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TextBoxSuma.TrailingIcon = null;
            this.TextBoxSuma.UseSystemPasswordChar = false;
            this.TextBoxSuma.ValidatingType = null;
            // 
            // ComboBoxPrimesc
            // 
            this.ComboBoxPrimesc.AutoResize = false;
            this.ComboBoxPrimesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxPrimesc.Depth = 0;
            this.ComboBoxPrimesc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxPrimesc.DropDownHeight = 174;
            this.ComboBoxPrimesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPrimesc.DropDownWidth = 121;
            resources.ApplyResources(this.ComboBoxPrimesc, "ComboBoxPrimesc");
            this.ComboBoxPrimesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxPrimesc.FormattingEnabled = true;
            this.ComboBoxPrimesc.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxPrimesc.Name = "ComboBoxPrimesc";
            this.ComboBoxPrimesc.StartIndex = 0;
            // 
            // materialLabel4
            // 
            resources.ApplyResources(this.materialLabel4, "materialLabel4");
            this.materialLabel4.Depth = 0;
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            // 
            // materialLabel3
            // 
            resources.ApplyResources(this.materialLabel3, "materialLabel3");
            this.materialLabel3.Depth = 0;
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            // 
            // TabPageTranzactii
            // 
            this.TabPageTranzactii.BackColor = System.Drawing.Color.White;
            this.TabPageTranzactii.Controls.Add(this.materialLabel5);
            this.TabPageTranzactii.Controls.Add(this.dateTimePickerTranzactii);
            this.TabPageTranzactii.Controls.Add(this.ButtonCautare);
            this.TabPageTranzactii.Controls.Add(this.dataGridViewTranzactii);
            resources.ApplyResources(this.TabPageTranzactii, "TabPageTranzactii");
            this.TabPageTranzactii.Name = "TabPageTranzactii";
            // 
            // materialLabel5
            // 
            resources.ApplyResources(this.materialLabel5, "materialLabel5");
            this.materialLabel5.Depth = 0;
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            // 
            // dateTimePickerTranzactii
            // 
            resources.ApplyResources(this.dateTimePickerTranzactii, "dateTimePickerTranzactii");
            this.dateTimePickerTranzactii.Name = "dateTimePickerTranzactii";
            // 
            // ButtonCautare
            // 
            resources.ApplyResources(this.ButtonCautare, "ButtonCautare");
            this.ButtonCautare.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonCautare.Depth = 0;
            this.ButtonCautare.HighEmphasis = true;
            this.ButtonCautare.Icon = null;
            this.ButtonCautare.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonCautare.Name = "ButtonCautare";
            this.ButtonCautare.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonCautare.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonCautare.UseAccentColor = false;
            this.ButtonCautare.UseVisualStyleBackColor = true;
            this.ButtonCautare.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // dataGridViewTranzactii
            // 
            this.dataGridViewTranzactii.AllowUserToAddRows = false;
            this.dataGridViewTranzactii.AllowUserToDeleteRows = false;
            this.dataGridViewTranzactii.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTranzactii.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTranzactii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTranzactii.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dataGridViewTranzactii, "dataGridViewTranzactii");
            this.dataGridViewTranzactii.Name = "dataGridViewTranzactii";
            this.dataGridViewTranzactii.ReadOnly = true;
            this.dataGridViewTranzactii.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTranzactii_CellContentClick);
            // 
            // tabPageistoric
            // 
            this.tabPageistoric.BackColor = System.Drawing.Color.White;
            this.tabPageistoric.Controls.Add(this.ButtonAfiseaza);
            this.tabPageistoric.Controls.Add(this.dateTimePickerCurs);
            this.tabPageistoric.Controls.Add(this.materialLabel6);
            this.tabPageistoric.Controls.Add(this.dataGridViewCursuri);
            resources.ApplyResources(this.tabPageistoric, "tabPageistoric");
            this.tabPageistoric.Name = "tabPageistoric";
            // 
            // ButtonAfiseaza
            // 
            resources.ApplyResources(this.ButtonAfiseaza, "ButtonAfiseaza");
            this.ButtonAfiseaza.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonAfiseaza.Depth = 0;
            this.ButtonAfiseaza.HighEmphasis = true;
            this.ButtonAfiseaza.Icon = null;
            this.ButtonAfiseaza.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAfiseaza.Name = "ButtonAfiseaza";
            this.ButtonAfiseaza.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonAfiseaza.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAfiseaza.UseAccentColor = false;
            this.ButtonAfiseaza.UseVisualStyleBackColor = true;
            this.ButtonAfiseaza.Click += new System.EventHandler(this.ButtonAfiseaza_Click);
            // 
            // dateTimePickerCurs
            // 
            resources.ApplyResources(this.dateTimePickerCurs, "dateTimePickerCurs");
            this.dateTimePickerCurs.Name = "dateTimePickerCurs";
            // 
            // materialLabel6
            // 
            resources.ApplyResources(this.materialLabel6, "materialLabel6");
            this.materialLabel6.Depth = 0;
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Click += new System.EventHandler(this.materialLabel6_Click);
            // 
            // dataGridViewCursuri
            // 
            this.dataGridViewCursuri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCursuri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridViewCursuri, "dataGridViewCursuri");
            this.dataGridViewCursuri.Name = "dataGridViewCursuri";
            // 
            // tabValute
            // 
            this.tabValute.BackColor = System.Drawing.Color.White;
            this.tabValute.Controls.Add(this.ButtonAdaugaValuta);
            this.tabValute.Controls.Add(this.dataGridViewValute);
            resources.ApplyResources(this.tabValute, "tabValute");
            this.tabValute.Name = "tabValute";
            // 
            // ButtonAdaugaValuta
            // 
            resources.ApplyResources(this.ButtonAdaugaValuta, "ButtonAdaugaValuta");
            this.ButtonAdaugaValuta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonAdaugaValuta.Depth = 0;
            this.ButtonAdaugaValuta.HighEmphasis = true;
            this.ButtonAdaugaValuta.Icon = null;
            this.ButtonAdaugaValuta.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAdaugaValuta.Name = "ButtonAdaugaValuta";
            this.ButtonAdaugaValuta.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonAdaugaValuta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAdaugaValuta.UseAccentColor = false;
            this.ButtonAdaugaValuta.UseVisualStyleBackColor = true;
            this.ButtonAdaugaValuta.Click += new System.EventHandler(this.ButtonAdaugaValuta_Click);
            // 
            // dataGridViewValute
            // 
            this.dataGridViewValute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewValute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewValute.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewValute.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewValute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridViewValute, "dataGridViewValute");
            this.dataGridViewValute.Name = "dataGridViewValute";
            this.dataGridViewValute.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageCursValutar.ResumeLayout(false);
            this.tabPageCursValutar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursulZilei)).EndInit();
            this.tabPageConvertor.ResumeLayout(false);
            this.tabPageConvertor.PerformLayout();
            this.TabPageTranzactii.ResumeLayout(false);
            this.TabPageTranzactii.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTranzactii)).EndInit();
            this.tabPageistoric.ResumeLayout(false);
            this.tabPageistoric.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursuri)).EndInit();
            this.tabValute.ResumeLayout(false);
            this.tabValute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageConvertor;
        private System.Windows.Forms.TabPage TabPageTranzactii;
        private System.Windows.Forms.TabPage tabPageCursValutar;
        private MaterialSkin.Controls.MaterialLabel LabelData;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox TextBoxSuma;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxPrimesc;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMaskedTextBox TextBoxPrimesc;
        private MaterialSkin.Controls.MaterialSwitch SwitchCumpar;
        private MaterialSkin.Controls.MaterialButton ButtonTranzactieEf;
        private System.Windows.Forms.DataGridView dataGridViewTranzactii;
        private MaterialSkin.Controls.MaterialButton ButtonCautare;
        private MaterialSkin.Controls.MaterialButton ButtonSuma;
        private System.Windows.Forms.DateTimePicker dateTimePickerTranzactii;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TabPage tabPageistoric;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DataGridView dataGridViewCursuri;
        private MaterialSkin.Controls.MaterialButton ButtonAfiseaza;
        private System.Windows.Forms.DateTimePicker dateTimePickerCurs;
        private System.Windows.Forms.DataGridView dataGridViewCursulZilei;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxSuma;
        private System.Windows.Forms.TabPage tabValute;
        private System.Windows.Forms.DataGridView dataGridViewValute;
        private MaterialSkin.Controls.MaterialButton ButtonAdaugaValuta;
    }
}

