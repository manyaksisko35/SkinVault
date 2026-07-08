using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        decimal gecerliFloat = 0.00m;
        SqlBaglantim bgl = new SqlBaglantim();

        void Listele()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Envanter", bgl.baglanti());
                da.Fill(dt);
                dgvEnvanter.DataSource = dt;
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while connecting to Vault: \n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowVault_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFiyat.Text) || string.IsNullOrWhiteSpace(txtFloat.Text))
                {
                    MessageBox.Show("Fiyat ve Float alanları boş bırakılamaz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlCommand komut = new SqlCommand("INSERT INTO Envanter (SilahTuru, SkinAdi, Kondisyon, FloatDegeri, Fiyat, InspectLink) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", cmbSilahTuru.Text);
                komut.Parameters.AddWithValue("@p2", txtSkinAdi.Text);
                komut.Parameters.AddWithValue("@p3", cmbKondisyon.Text);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtFloat.Text)); 
                komut.Parameters.AddWithValue("@p5", decimal.Parse(txtFiyat.Text));
                komut.Parameters.AddWithValue("@p6", txtInspectLink.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Item successfully registered to the vault!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEnvanter.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvEnvanter.SelectedRows[0].Cells[0].Value);
                    SqlCommand komut = new SqlCommand("DELETE FROM Envanter WHERE SkinID=@p1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Item has been permanently removed.", "Withdraw Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Listele();
                }
                else
                {
                    MessageBox.Show("Please select an item from the list to remove!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi sırasında hata: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEnvanter.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvEnvanter.SelectedRows[0].Cells[0].Value);
                    SqlCommand komut = new SqlCommand("UPDATE Envanter SET SilahTuru=@p1, SkinAdi=@p2, Kondisyon=@p3, FloatDegeri=@p4, Fiyat=@p5 , InspectLink=@p6 WHERE SkinID=@p7", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", cmbSilahTuru.Text);
                    komut.Parameters.AddWithValue("@p2", txtSkinAdi.Text);
                    komut.Parameters.AddWithValue("@p3", cmbKondisyon.Text);
                    komut.Parameters.AddWithValue("@p4", Convert.ToDecimal(txtFloat.Text.Replace(".", ",")));
                    komut.Parameters.AddWithValue("@p5", Convert.ToDecimal(txtFiyat.Text.Replace(".", ",")));
                    komut.Parameters.AddWithValue("@p6", txtInspectLink.Text);
                    komut.Parameters.AddWithValue("@p7", id);

                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Inventory details updated successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                }
                else
                {
                    MessageBox.Show("Lütfen güncellenecek satırı seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Orange, Color.FromArgb(64, 64, 64));
        }

        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                    box.ClientRectangle.Y + (int)(strSize.Height / 2),
                    box.ClientRectangle.Width - 1,
                    box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                g.Clear(this.BackColor);
                g.DrawRectangle(borderPen, rect);
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);
            }
        }

        private void dgvEnvanter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEnvanter.Rows[e.RowIndex];

                cmbSilahTuru.Text = row.Cells[1].Value.ToString();
                txtSkinAdi.Text = row.Cells[2].Value.ToString();
                cmbKondisyon.Text = row.Cells[3].Value.ToString();
                txtFloat.Text = row.Cells[4].Value.ToString();
                txtFiyat.Text = row.Cells[5].Value.ToString();
                txtInspectLink.Text = row.Cells[6].Value.ToString();

                string skinAdi = row.Cells[2].Value.ToString();
                decimal floatDegeri = Convert.ToDecimal(row.Cells[4].Value);
                gecerliFloat = floatDegeri;
                picFloatBar.Invalidate();
                string resimYolu = Application.StartupPath + @"\Skins\" + skinAdi + ".png";

                if (System.IO.File.Exists(resimYolu))
                {
                    picSkinPreview.Image = Image.FromFile(resimYolu);
                }
                else
                {
                    picSkinPreview.Image = null;
                }
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

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
            float floatX = (float)gecerliFloat * w;
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

        private void Form2_Load(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle(0, 0, picFloatBar.Width, picFloatBar.Height);
            picFloatBar.Region = new Region(YuvarlakKoseCiz(r, 10));
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
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

        private void txtFloat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}