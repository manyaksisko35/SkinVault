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

namespace WindowsFormsApp1
{
    public partial class SkinCard : UserControl
    {
        public SkinCard()
        {
            InitializeComponent();
        }

        decimal kartFloatDegeri = 0;

        public void KartVerileriniDoldur(string skinAdi, decimal fiyat, decimal floatDegeri, string inspectLink)
        {
            kartFloatDegeri = floatDegeri;
            lblFiyat.Text = "$" + fiyat.ToString("N2");
            lblFloat.Text = floatDegeri.ToString();
            kartFloatDegeri = floatDegeri;
            picFloatBar.Invalidate();

            string resimYolu = Application.StartupPath + @"\Skins\" + skinAdi + ".png";
            if (System.IO.File.Exists(resimYolu)) picSkin.Image = Image.FromFile(resimYolu);
            picFloatBar.Invalidate();
            btnInspect.Tag = inspectLink;
        }
        private void btnInspect_Click(object sender, EventArgs e)
        {
            if (btnInspect.Tag != null)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(btnInspect.Tag.ToString()) { UseShellExecute = true });
            }
        }
        private void picFloatBar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int w = picFloatBar.Width;
            int h = picFloatBar.Height;

            g.FillRectangle(new SolidBrush(Color.FromArgb(0, 150, 50)), 0, 0, w * 0.07f, h);
            g.FillRectangle(new SolidBrush(Color.FromArgb(100, 200, 50)), w * 0.07f, 0, w * 0.08f, h);
            g.FillRectangle(new SolidBrush(Color.FromArgb(180, 220, 50)), w * 0.15f, 0, w * 0.23f, h);
            g.FillRectangle(new SolidBrush(Color.FromArgb(220, 100, 80)), w * 0.38f, 0, w * 0.07f, h);
            g.FillRectangle(new SolidBrush(Color.FromArgb(250, 50, 50)), w * 0.45f, 0, w * 0.55f, h);
            float floatX = (float)kartFloatDegeri * w;
            if (floatX < 2) floatX = 2;
            if (floatX > w - 3) floatX = w - 3;

            g.FillRectangle(Brushes.White, floatX - 2, 0, 4, h);
            g.DrawRectangle(Pens.DarkGray, floatX - 2, 0, 4, h);
        }

        private GraphicsPath YuvarlakKoseCiz(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void SkinCard_Load(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle(0, 0, picFloatBar.Width, picFloatBar.Height);
            picFloatBar.Region = new Region(YuvarlakKoseCiz(r, 10));
        }
    }
}
