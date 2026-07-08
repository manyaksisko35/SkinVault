using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMarket : Form
    {
        public FormMarket(string gelenKullanici)
        {
            InitializeComponent();
            lblKullaniciAdi.Text = gelenKullanici;
        }

        private void FormMarket_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            SqlBaglantim bgl = new SqlBaglantim();
            SqlCommand komut = new SqlCommand("SELECT * FROM Envanter", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                SkinCard yeniKart = new SkinCard();

                string sAd = dr["SkinAdi"].ToString();
                decimal fyt = Convert.ToDecimal(dr["Fiyat"]);
                decimal flt = Convert.ToDecimal(dr["FloatDegeri"]);
                string gercekLink = dr["InspectLink"].ToString();
                yeniKart.KartVerileriniDoldur(sAd, fyt, flt, gercekLink);

                flowLayoutPanel1.Controls.Add(yeniKart);
            }

            bgl.baglanti().Close();
        }

        private void FormMarket_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Are you sure you want to log out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (secim == DialogResult.Yes)
            {
                Application.OpenForms["Form1"].Show();
                this.Hide();
            }
        }

        private void btnSteam_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("steam://open/main") { UseShellExecute = true });
            }
            catch (Exception)
            {
                MessageBox.Show("Steam is not installed on this computer or could not be launched.", "Steam Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
