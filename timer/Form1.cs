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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gecenSaniye=0;
        int istenenDakika = 0, istenenSaniye=0;
        private void Form1_Load(object sender, EventArgs e)
        {
           timer2.Start(); //sistem saatini yenileyen timer
           timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gecenSaniye++;
            txtGecensure.Text= TimeSpan.FromSeconds(gecenSaniye).ToString(@"mm\:ss") + " geçti";
            istenenSaniye--;
            txtgerisayim.Text = TimeSpan.FromSeconds(istenenSaniye).ToString(@"mm\:ss");
            if (istenenSaniye == 0) { 
                timer1.Stop();
                MessageBox.Show("Geri Sayım Tamamlandı", "Sürenin Sonu");
            }
            progressBar1.Value = gecenSaniye/(istenenDakika*60)*100;
                   
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            txtSistemsure.Text = DateTime.Now.ToString("hh\\:mm\\:ss");
        }

        private void baslabuton_Click(object sender, EventArgs e)
        {
            gecenSaniye = 0;
            istenenDakika = int.Parse(txtBoxIstenensure.Text);
            istenenSaniye = istenenDakika * 60;
            timer1.Start();
        }

        private void durdurbuton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void devambuton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
