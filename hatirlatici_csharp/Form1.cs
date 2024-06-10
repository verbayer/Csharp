using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Threading;
using AxWMPLib;
using System.Security.Cryptography;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kayitsayi = 0;
        string gun = "", tarih = "", saat = "";
        private SaveFileDialog sfd = new SaveFileDialog();
        private List<DateTime> tarihSaatListesi = new List<DateTime>();
        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                string pathToFile = AppDomain.CurrentDomain.BaseDirectory + "\\ayarlar.dat";

                if (File.Exists(pathToFile))
                {
                    string filePath = File.ReadAllText(pathToFile).Trim();
                    if (filePath != null)
                    {
                        sfd.FileName = filePath;
                        StreamReader read = new StreamReader(filePath);
                        while (!read.EndOfStream)
                        {
                            string satir = read.ReadLine();
                            listBox1.Items.Add(satir);
                        }
                        read.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Config dosyası bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dosya okunurken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dateTimePicker1.Enabled = false;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            kayitsayi = listBox1.Items.Count;
            labelKayit.Text = "Kayıt Sayısı: " + kayitsayi.ToString();
            timergenel.Interval = 1000;
            timervakitctrl.Interval = 1000;
            timeralarm.Interval = 1000;
            timergenel.Start();
            timervakitctrl.Start();
            btnalarm.Visible = false;
            grouppanel.BackColor = Color.WhiteSmoke;
            bildirsim.Visible = true;
            bildirsim.BalloonTipTitle = "İş Takibi 1.0 Çalışıyor";
            bildirsim.BalloonTipText = "İş Takibi ile işlerinizi atlamayın";
            bildirsim.ShowBalloonTip(10000);
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string secilen = listBox1.SelectedItem.ToString();
                string[] parts = secilen.Split(new string[] { " - " }, StringSplitOptions.None);
                textisAdi.Text = parts[0];
                textAciklama.Text = parts[1];
                if (parts.Length == 3)
                {
                    HatirlaCheck.Checked = true;
                    dateTimePicker1.Text = parts[2];
                }
                else
                {
                    HatirlaCheck.Checked = false;
                    dateTimePicker1.Text = DateTime.Now.ToString();
                }
            }
        }

        private void HatirlaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (HatirlaCheck.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker1.Text = DateTime.Now.ToString();
            }
            else
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker1.Text = DateTime.Now.ToString();
            }
        }

        private void textisAdi_MouseEnter(object sender, EventArgs e)
        {
            textisAdi.BackColor = Color.LightYellow;
        }

        private void textisAdi_MouseLeave(object sender, EventArgs e)
        {
            textisAdi.BackColor = Color.White;
        }

        private void textAciklama_MouseEnter(object sender, EventArgs e)
        {
            textisAdi.BackColor = Color.LightYellow;
        }

        private void textAciklama_MouseLeave(object sender, EventArgs e)
        {
            textAciklama.BackColor = Color.White;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (textisAdi.Text != "" && textAciklama.Text != "")
            {
                if (HatirlaCheck.Checked)
                {
                    string isim = textisAdi.Text;
                    string aciklama = textAciklama.Text;
                    DateTime tarihSaat = dateTimePicker1.Value;

                    string eleman = $"{isim} - {aciklama} - {tarihSaat}";
                    listBox1.Items.Add(eleman);
                    tarihSaatListesi.Add(tarihSaat);
                    kayitsayi++;
                    labelKayit.Text = "Kayıt sayısı: " + kayitsayi.ToString();
                }
                else
                {
                    listBox1.Items.Add(textisAdi.Text + " - " + textAciklama.Text);
                    kayitsayi++;
                    labelKayit.Text = "Kayıt sayısı: " + kayitsayi.ToString();
                }
            }
            else
                MessageBox.Show("İş adı ve Açıklama boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            textisAdi.Text = "";
            textAciklama.Text = "";
            dateTimePicker1.Enabled = false;
            HatirlaCheck.Checked = false;
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            DialogResult duzelt = MessageBox.Show("Seçilen kayıt düzeltilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (duzelt == DialogResult.Yes)
            {
                if (listBox1.SelectedIndex != -1)
                {
                    if (textisAdi.Text != "" && textAciklama.Text != "")
                    {
                        int index = listBox1.SelectedIndex;
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        if (HatirlaCheck.Checked)
                        {
                            listBox1.Items.Insert(index, (textisAdi.Text + " - " + textAciklama.Text + " - " + dateTimePicker1.Text));
                            tarihSaatListesi.Add(dateTimePicker1.Value);
                        }
                        else
                        {
                            listBox1.Items.Insert(index, (textisAdi.Text + " - " + textAciklama.Text));
                        }
                    }
                    else
                        MessageBox.Show("İş adı ve Açıklama boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSecSil_Click(object sender, EventArgs e)
        {
            DialogResult silme = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (silme == DialogResult.Yes)
            {
                if (listBox1.SelectedItem != null)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    kayitsayi--;
                    labelKayit.Text = "Kayıt Sayısı: " + kayitsayi.ToString();
                }
                else
                    MessageBox.Show("Lütfen bir eleman seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnDosyaKaydet_Click(object sender, EventArgs e)
        {
            sfd.Filter = " .txt Dosyası (*.txt)|*.txt| Tüm Dosyalar (*.*)|*.txt";
            sfd.Title = "Kaydedilecek Dosyayı Seçin";
            sfd.CreatePrompt = true;
            sfd.OverwritePrompt = true;
            sfd.DefaultExt = ".txt";
            sfd.ShowDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        sw.WriteLine(listBox1.Items[i]);
                    }
                    StreamWriter dosyakonum = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\ayarlar.dat");
                    dosyakonum.WriteLine(sfd.FileName);
                    dosyakonum.Close();
                    sw.Close();
                    MessageBox.Show("Dosya başarı ile kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Dosya kaydedilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            StreamWriter sw = new StreamWriter(sfd.FileName);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
               sw.WriteLine(listBox1.Items[i]);
            }
            sw.Close(); 
            
        }


        private void timervakitctrl_Tick(object sender, EventArgs e)
        {
            DateTime simdikiZaman = DateTime.Now;
            foreach (DateTime tarihSaat in tarihSaatListesi.ToList())
            {
                TimeSpan fark = simdikiZaman - tarihSaat;

                if (Math.Abs(fark.TotalSeconds) < 1)
                {
                    timervakitctrl.Stop();
                    string eslesenEleman = listBox1.Items.Cast<string>().FirstOrDefault(item => item.Contains(tarihSaat.ToString()));

                    if (eslesenEleman != null)
                    {
                        timervakitctrl.Stop();
                        MediaPlayer1.URL = AppDomain.CurrentDomain.BaseDirectory + "\\alarm.wav";
                        timeralarm.Start();
                        listBox1.SelectedItem = eslesenEleman;
                        string[] parts = eslesenEleman.Split(new string[] { " - " }, StringSplitOptions.None);
                        labelZaman.Text = parts[0] + " " + parts[1];
                        if (WindowState == FormWindowState.Minimized)
                        {
                            bildirsim.BalloonTipTitle = "İş Takibi Çalışıyor...";
                            bildirsim.BalloonTipText = parts[0] + " " + parts[1];
                            bildirsim.ShowBalloonTip(20000); 
                        }
                        
                    }
                }
            }
        }

        private void timeralarm_Tick(object sender, EventArgs e)
        {
            btnalarm.Visible = true;
            alarmsimge.Visible = true;
            
            if (grouppanel.BackColor == Color.WhiteSmoke)
            {
                grouppanel.BackColor = Color.Blue;
                labelZaman.ForeColor = Color.White;
            }
            else if (grouppanel.BackColor == Color.Blue)
            {
                grouppanel.BackColor = Color.WhiteSmoke;
                labelZaman.ForeColor = Color.Black;
            }
            if (MediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timeralarm.Stop();
                btnalarm.Visible=false;
                grouppanel.BackColor = Color.WhiteSmoke;
                alarmsimge.Visible = false;
                labelZaman.ForeColor = Color.Black;
            }
            timervakitctrl.Start();
            
        }

        private void btnalarm_Click(object sender, EventArgs e)
        {
            if (MediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying) { 
                MediaPlayer1.Ctlcontrols.pause();
                btnalarm.Text = "Devam Ettir";
            }
            else if(MediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                MediaPlayer1.Ctlcontrols.play();
                btnalarm.Text = "Durdur";
            }     
        }

       

        private void timergenel_Tick(object sender, EventArgs e)
        {

            gun = DateTime.Now.ToString("dddd", new System.Globalization.CultureInfo("tr-TR"));
            tarih = DateTime.Now.ToString("dd/MM/yyyy");
            saat = DateTime.Now.ToString("HH:mm:ss");
            if(!timeralarm.Enabled)
                labelZaman.Text = "Bugün: " + gun + " " + tarih + " Saat: " + saat;
        }

        private void btnHepSil_Click(object sender, EventArgs e)
        {
            DialogResult hepsisil = MessageBox.Show("Hepsini silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hepsisil == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                kayitsayi = 0;
                labelKayit.Text = "Kayıt sayısı: " + kayitsayi.ToString();
            }
        }



    }
}
