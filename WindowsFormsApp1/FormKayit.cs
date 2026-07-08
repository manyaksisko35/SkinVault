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
    public partial class FormKayit : Form
    {
        public FormKayit()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                string.IsNullOrWhiteSpace(txtEposta.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!txtEposta.Text.Contains("@") || !txtEposta.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address!", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlBaglantim bgl = new SqlBaglantim();
                SqlCommand komut = new SqlCommand("INSERT INTO Kullanicilar (KullaniciAdi, Sifre, Eposta) VALUES (@p1, @p2, @p3)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                komut.Parameters.AddWithValue("@p3", txtEposta.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Account successfully created! You can now log in.", "Welcome to SkinVault", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This username is already taken or a connection error occurred!\n" + ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
