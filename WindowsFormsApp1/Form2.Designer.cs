namespace WindowsFormsApp1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.txtSkinAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInspectLink = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFiyat = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFloat = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKondisyon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSilahTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowVault = new Guna.UI2.WinForms.Guna2Button();
            this.btnSil = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuncelle = new Guna.UI2.WinForms.Guna2Button();
            this.btnEkle = new Guna.UI2.WinForms.Guna2Button();
            this.skinVaultDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinVaultDBDataSet = new WindowsFormsApp1.SkinVaultDBDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvEnvanter = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.picFloatBar = new System.Windows.Forms.PictureBox();
            this.picSkinPreview = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinVaultDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinVaultDBDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvanter)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFloatBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkinPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btnLogout);
            this.guna2ShadowPanel1.Controls.Add(this.pictureBox1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(-8, -11);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(196, 832);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Maroon;
            this.btnLogout.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(-1, 745);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(191, 55);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.DarkRed;
            // 
            // txtSkinAdi
            // 
            this.txtSkinAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSkinAdi.DefaultText = "";
            this.txtSkinAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSkinAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSkinAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSkinAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSkinAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSkinAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSkinAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSkinAdi.Location = new System.Drawing.Point(157, 69);
            this.txtSkinAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSkinAdi.Name = "txtSkinAdi";
            this.txtSkinAdi.PlaceholderText = "";
            this.txtSkinAdi.SelectedText = "";
            this.txtSkinAdi.Size = new System.Drawing.Size(205, 31);
            this.txtSkinAdi.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtInspectLink);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFloat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbKondisyon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbSilahTuru);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSkinAdi);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupBox1.Location = new System.Drawing.Point(209, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(404, 277);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 222);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Inspect Link:";
            // 
            // txtInspectLink
            // 
            this.txtInspectLink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInspectLink.DefaultText = "";
            this.txtInspectLink.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInspectLink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInspectLink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInspectLink.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInspectLink.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInspectLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInspectLink.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInspectLink.Location = new System.Drawing.Point(157, 222);
            this.txtInspectLink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInspectLink.Name = "txtInspectLink";
            this.txtInspectLink.PlaceholderText = "";
            this.txtInspectLink.SelectedText = "";
            this.txtInspectLink.Size = new System.Drawing.Size(205, 31);
            this.txtInspectLink.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price :";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiyat.DefaultText = "";
            this.txtFiyat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiyat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiyat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiyat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiyat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiyat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiyat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiyat.Location = new System.Drawing.Point(157, 183);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.PlaceholderText = "";
            this.txtFiyat.SelectedText = "";
            this.txtFiyat.Size = new System.Drawing.Size(205, 31);
            this.txtFiyat.TabIndex = 10;
            this.txtFiyat.TextChanged += new System.EventHandler(this.txtFiyat_TextChanged);
            this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyat_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Float :";
            // 
            // txtFloat
            // 
            this.txtFloat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFloat.DefaultText = "";
            this.txtFloat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFloat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFloat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFloat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFloat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFloat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFloat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFloat.Location = new System.Drawing.Point(157, 145);
            this.txtFloat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFloat.Name = "txtFloat";
            this.txtFloat.PlaceholderText = "";
            this.txtFloat.SelectedText = "";
            this.txtFloat.Size = new System.Drawing.Size(205, 31);
            this.txtFloat.TabIndex = 8;
            this.txtFloat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFloat_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Condition :";
            // 
            // cmbKondisyon
            // 
            this.cmbKondisyon.FormattingEnabled = true;
            this.cmbKondisyon.Items.AddRange(new object[] {
            "Factory New",
            " Minimal Wear",
            " Field-Tested",
            " Well-Worn",
            " Battle-Scarred"});
            this.cmbKondisyon.Location = new System.Drawing.Point(157, 107);
            this.cmbKondisyon.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKondisyon.Name = "cmbKondisyon";
            this.cmbKondisyon.Size = new System.Drawing.Size(204, 28);
            this.cmbKondisyon.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Skin Name :";
            // 
            // cmbSilahTuru
            // 
            this.cmbSilahTuru.FormattingEnabled = true;
            this.cmbSilahTuru.Items.AddRange(new object[] {
            "AK-47",
            "M4A4",
            "M4A1-S",
            "AWP",
            "Desert Eagle",
            "USP-S",
            "Glock-18",
            "Karambit",
            "Butterfly Knife",
            "Galil-AR"});
            this.cmbSilahTuru.Location = new System.Drawing.Point(157, 31);
            this.cmbSilahTuru.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSilahTuru.Name = "cmbSilahTuru";
            this.cmbSilahTuru.Size = new System.Drawing.Size(204, 28);
            this.cmbSilahTuru.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Weapon Type :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnShowVault);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupBox2.Location = new System.Drawing.Point(641, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(404, 277);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnShowVault
            // 
            this.btnShowVault.BorderRadius = 10;
            this.btnShowVault.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowVault.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowVault.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowVault.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowVault.FillColor = System.Drawing.Color.Goldenrod;
            this.btnShowVault.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowVault.ForeColor = System.Drawing.Color.White;
            this.btnShowVault.Location = new System.Drawing.Point(32, 49);
            this.btnShowVault.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowVault.Name = "btnShowVault";
            this.btnShowVault.Size = new System.Drawing.Size(345, 42);
            this.btnShowVault.TabIndex = 3;
            this.btnShowVault.Text = "Load Data";
            this.btnShowVault.Click += new System.EventHandler(this.btnShowVault_Click);
            // 
            // btnSil
            // 
            this.btnSil.BorderRadius = 10;
            this.btnSil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSil.FillColor = System.Drawing.Color.Maroon;
            this.btnSil.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(32, 199);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(345, 42);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Remove Skin";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BorderRadius = 10;
            this.btnGuncelle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuncelle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuncelle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuncelle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuncelle.FillColor = System.Drawing.Color.Olive;
            this.btnGuncelle.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(32, 150);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(345, 42);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Update Skin";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BorderRadius = 10;
            this.btnEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEkle.FillColor = System.Drawing.Color.Green;
            this.btnEkle.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(32, 100);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(345, 42);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Add to Vault";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // skinVaultDBDataSetBindingSource
            // 
            this.skinVaultDBDataSetBindingSource.DataSource = this.skinVaultDBDataSet;
            this.skinVaultDBDataSetBindingSource.Position = 0;
            // 
            // skinVaultDBDataSet
            // 
            this.skinVaultDBDataSet.DataSetName = "SkinVaultDBDataSet";
            this.skinVaultDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgvEnvanter);
            this.groupBox3.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupBox3.Location = new System.Drawing.Point(209, 310);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1264, 452);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data";
            this.groupBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dgvEnvanter
            // 
            this.dgvEnvanter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnvanter.BackgroundColor = System.Drawing.Color.Black;
            this.dgvEnvanter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnvanter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnvanter.Location = new System.Drawing.Point(4, 24);
            this.dgvEnvanter.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEnvanter.Name = "dgvEnvanter";
            this.dgvEnvanter.RowHeadersWidth = 51;
            this.dgvEnvanter.Size = new System.Drawing.Size(1256, 424);
            this.dgvEnvanter.TabIndex = 0;
            this.dgvEnvanter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnvanter_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.picFloatBar);
            this.groupBox4.Controls.Add(this.picSkinPreview);
            this.groupBox4.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupBox4.Location = new System.Drawing.Point(1069, 22);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(404, 277);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Preview";
            this.groupBox4.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // picFloatBar
            // 
            this.picFloatBar.Location = new System.Drawing.Point(69, 212);
            this.picFloatBar.Margin = new System.Windows.Forms.Padding(4);
            this.picFloatBar.Name = "picFloatBar";
            this.picFloatBar.Size = new System.Drawing.Size(271, 26);
            this.picFloatBar.TabIndex = 15;
            this.picFloatBar.TabStop = false;
            this.picFloatBar.Paint += new System.Windows.Forms.PaintEventHandler(this.picFloatBar_Paint);
            // 
            // picSkinPreview
            // 
            this.picSkinPreview.FillColor = System.Drawing.Color.Transparent;
            this.picSkinPreview.ImageRotate = 0F;
            this.picSkinPreview.Location = new System.Drawing.Point(115, 52);
            this.picSkinPreview.Margin = new System.Windows.Forms.Padding(4);
            this.picSkinPreview.Name = "picSkinPreview";
            this.picSkinPreview.Size = new System.Drawing.Size(176, 146);
            this.picSkinPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSkinPreview.TabIndex = 14;
            this.picSkinPreview.TabStop = false;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ControlBox1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1443, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(47, 26);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1392, 0);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(51, 26);
            this.guna2ControlBox2.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1489, 789);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.ForeColor = System.Drawing.Color.Gold;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinVaultDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinVaultDBDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvanter)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFloatBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkinPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2TextBox txtSkinAdi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKondisyon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSilahTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtFiyat;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtFloat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource skinVaultDBDataSetBindingSource;
        private SkinVaultDBDataSet skinVaultDBDataSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button btnSil;
        private Guna.UI2.WinForms.Guna2Button btnGuncelle;
        private Guna.UI2.WinForms.Guna2Button btnEkle;
        private Guna.UI2.WinForms.Guna2Button btnShowVault;
        private System.Windows.Forms.DataGridView dgvEnvanter;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2PictureBox picSkinPreview;
        private System.Windows.Forms.PictureBox picFloatBar;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtInspectLink;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}