namespace WindowsFormsApp1
{
    partial class SkinCard
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picSkin = new System.Windows.Forms.PictureBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblFloat = new System.Windows.Forms.Label();
            this.picFloatBar = new System.Windows.Forms.PictureBox();
            this.btnInspect = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSkin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFloatBar)).BeginInit();
            this.SuspendLayout();
            // 
            // picSkin
            // 
            this.picSkin.Location = new System.Drawing.Point(12, 8);
            this.picSkin.Name = "picSkin";
            this.picSkin.Size = new System.Drawing.Size(85, 79);
            this.picSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSkin.TabIndex = 0;
            this.picSkin.TabStop = false;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.ForeColor = System.Drawing.Color.White;
            this.lblFiyat.Location = new System.Drawing.Point(112, 4);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(63, 26);
            this.lblFiyat.TabIndex = 1;
            this.lblFiyat.Text = "label1";
            // 
            // lblFloat
            // 
            this.lblFloat.AutoSize = true;
            this.lblFloat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFloat.ForeColor = System.Drawing.Color.Gray;
            this.lblFloat.Location = new System.Drawing.Point(114, 47);
            this.lblFloat.Name = "lblFloat";
            this.lblFloat.Size = new System.Drawing.Size(45, 17);
            this.lblFloat.TabIndex = 2;
            this.lblFloat.Text = "label1";
            // 
            // picFloatBar
            // 
            this.picFloatBar.Location = new System.Drawing.Point(116, 67);
            this.picFloatBar.Name = "picFloatBar";
            this.picFloatBar.Size = new System.Drawing.Size(91, 18);
            this.picFloatBar.TabIndex = 16;
            this.picFloatBar.TabStop = false;
            this.picFloatBar.Paint += new System.Windows.Forms.PaintEventHandler(this.picFloatBar_Paint);
            // 
            // btnInspect
            // 
            this.btnInspect.BorderRadius = 10;
            this.btnInspect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInspect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInspect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInspect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInspect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInspect.Font = new System.Drawing.Font("Impact", 11.25F);
            this.btnInspect.ForeColor = System.Drawing.Color.White;
            this.btnInspect.Location = new System.Drawing.Point(240, 13);
            this.btnInspect.Name = "btnInspect";
            this.btnInspect.Size = new System.Drawing.Size(81, 69);
            this.btnInspect.TabIndex = 17;
            this.btnInspect.Text = "INSPECT IN GAME";
            this.btnInspect.Click += new System.EventHandler(this.btnInspect_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // SkinCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.btnInspect);
            this.Controls.Add(this.picFloatBar);
            this.Controls.Add(this.lblFloat);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.picSkin);
            this.Name = "SkinCard";
            this.Size = new System.Drawing.Size(350, 100);
            this.Load += new System.EventHandler(this.SkinCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSkin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFloatBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSkin;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblFloat;
        private System.Windows.Forms.PictureBox picFloatBar;
        private Guna.UI2.WinForms.Guna2Button btnInspect;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
