using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0) 
            {
                this.Opacity += 0.05; 
            }
            else
            {
                timerFadeIn.Stop(); 
                timerBekleme.Start();
            }
        }

        private void timerBekleme_Tick(object sender, EventArgs e)
        {
            timerBekleme.Stop(); 
            timerFadeOut.Start();
        }

        private void timerFadeOut_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0) 
            {
                this.Opacity -= 0.05; 
            }
            else 
            {
                timerFadeOut.Stop(); 

                Form1 loginEkrani = new Form1(); 
                loginEkrani.Show();

                this.Hide();
            }
        }
    }
}
