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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlBaglantim bgl = new SqlBaglantim();

            SqlCommand komut = new SqlCommand("SELECT * FROM Kullanicilar WHERE KullaniciAdi=@p1 AND Sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read()) 
            {
                int yetkiDurumu = Convert.ToInt32(dr["Yetki"]);

                if (yetkiDurumu == 1)
                {
                    MessageBox.Show("Welcome Admin! Accessing management panel...", "SkinVault Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form2 anaSayfa = new Form2();
                    anaSayfa.Show();
                }
                else
                {
                    MessageBox.Show("Login successful! Viewing market...", "SkinVault Market", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMarket frmMkt = new FormMarket(txtKullaniciAdi.Text);
                    frmMkt.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bgl.baglanti().Close();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }



        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnKayitEkrani_Click(object sender, EventArgs e)
        {
            FormKayit kayitEkrani = new FormKayit();
            kayitEkrani.ShowDialog();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
