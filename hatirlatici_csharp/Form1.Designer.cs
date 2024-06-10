namespace WindowsFormsApp3
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDuzelt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textAciklama = new System.Windows.Forms.TextBox();
            this.textisAdi = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.HatirlaCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSecSil = new System.Windows.Forms.Button();
            this.btnHepSil = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.labelKayit = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grouppanel = new System.Windows.Forms.GroupBox();
            this.btnalarm = new System.Windows.Forms.Button();
            this.alarmsimge = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelZaman = new System.Windows.Forms.Label();
            this.saatsimge = new System.Windows.Forms.PictureBox();
            this.timergenel = new System.Windows.Forms.Timer(this.components);
            this.timervakitctrl = new System.Windows.Forms.Timer(this.components);
            this.timeralarm = new System.Windows.Forms.Timer(this.components);
            this.MediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.bildirsim = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.grouppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarmsimge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saatsimge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "200389.png");
            this.ımageList1.Images.SetKeyName(1, "1869668.png");
            this.ımageList1.Images.SetKeyName(2, "image2s.png");
            this.ımageList1.Images.SetKeyName(3, "images.png");
            this.ımageList1.Images.SetKeyName(4, "process-stop-svg.png");
            this.ımageList1.Images.SetKeyName(5, "unity-datetime-panel.png");
            this.ımageList1.Images.SetKeyName(6, "zoom-in.png");
            this.ımageList1.Images.SetKeyName(7, "Trash.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDuzelt);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textAciklama);
            this.groupBox1.Controls.Add(this.textisAdi);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.HatirlaCheck);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnDuzelt
            // 
            this.btnDuzelt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuzelt.ImageIndex = 0;
            this.btnDuzelt.ImageList = this.ımageList1;
            this.btnDuzelt.Location = new System.Drawing.Point(279, 160);
            this.btnDuzelt.Name = "btnDuzelt";
            this.btnDuzelt.Size = new System.Drawing.Size(148, 34);
            this.btnDuzelt.TabIndex = 9;
            this.btnDuzelt.Text = "Dü&zelt";
            this.btnDuzelt.UseVisualStyleBackColor = true;
            this.btnDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 2;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(143, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "&Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 6;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(5, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Yeni Kayıt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // textAciklama
            // 
            this.textAciklama.Location = new System.Drawing.Point(87, 75);
            this.textAciklama.Name = "textAciklama";
            this.textAciklama.Size = new System.Drawing.Size(293, 22);
            this.textAciklama.TabIndex = 6;
            this.textAciklama.MouseEnter += new System.EventHandler(this.textAciklama_MouseEnter);
            this.textAciklama.MouseLeave += new System.EventHandler(this.textAciklama_MouseLeave);
            // 
            // textisAdi
            // 
            this.textisAdi.Location = new System.Drawing.Point(87, 35);
            this.textisAdi.Name = "textisAdi";
            this.textisAdi.Size = new System.Drawing.Size(293, 22);
            this.textisAdi.TabIndex = 5;
            this.textisAdi.MouseEnter += new System.EventHandler(this.textisAdi_MouseEnter);
            this.textisAdi.MouseLeave += new System.EventHandler(this.textisAdi_MouseLeave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // HatirlaCheck
            // 
            this.HatirlaCheck.AutoSize = true;
            this.HatirlaCheck.Location = new System.Drawing.Point(87, 119);
            this.HatirlaCheck.Name = "HatirlaCheck";
            this.HatirlaCheck.Size = new System.Drawing.Size(71, 20);
            this.HatirlaCheck.TabIndex = 3;
            this.HatirlaCheck.Text = "Hatırlat";
            this.HatirlaCheck.UseVisualStyleBackColor = true;
            this.HatirlaCheck.CheckedChanged += new System.EventHandler(this.HatirlaCheck_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "İş Adı";
            // 
            // btnSecSil
            // 
            this.btnSecSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecSil.ImageIndex = 4;
            this.btnSecSil.ImageList = this.ımageList1;
            this.btnSecSil.Location = new System.Drawing.Point(18, 492);
            this.btnSecSil.Name = "btnSecSil";
            this.btnSecSil.Size = new System.Drawing.Size(132, 34);
            this.btnSecSil.TabIndex = 10;
            this.btnSecSil.Text = "Seçileni &Sil";
            this.btnSecSil.UseVisualStyleBackColor = true;
            this.btnSecSil.Click += new System.EventHandler(this.btnSecSil_Click);
            // 
            // btnHepSil
            // 
            this.btnHepSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHepSil.ImageIndex = 7;
            this.btnHepSil.ImageList = this.ımageList1;
            this.btnHepSil.Location = new System.Drawing.Point(156, 492);
            this.btnHepSil.Name = "btnHepSil";
            this.btnHepSil.Size = new System.Drawing.Size(132, 34);
            this.btnHepSil.TabIndex = 11;
            this.btnHepSil.Text = "&Hepsini Sil";
            this.btnHepSil.UseVisualStyleBackColor = true;
            this.btnHepSil.Click += new System.EventHandler(this.btnHepSil_Click);
            // 
            // button6
            // 
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageIndex = 3;
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(297, 492);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 34);
            this.button6.TabIndex = 12;
            this.button6.Text = "&Dosyaya kaydet";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnDosyaKaydet_Click);
            // 
            // labelKayit
            // 
            this.labelKayit.AutoSize = true;
            this.labelKayit.Location = new System.Drawing.Point(329, 473);
            this.labelKayit.Name = "labelKayit";
            this.labelKayit.Size = new System.Drawing.Size(89, 16);
            this.labelKayit.TabIndex = 10;
            this.labelKayit.Text = "Kayıt Sayısı: 0";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 290);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(434, 180);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // grouppanel
            // 
            this.grouppanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grouppanel.Controls.Add(this.btnalarm);
            this.grouppanel.Controls.Add(this.alarmsimge);
            this.grouppanel.Controls.Add(this.panel1);
            this.grouppanel.Controls.Add(this.labelZaman);
            this.grouppanel.Controls.Add(this.saatsimge);
            this.grouppanel.Location = new System.Drawing.Point(11, 221);
            this.grouppanel.Name = "grouppanel";
            this.grouppanel.Size = new System.Drawing.Size(434, 59);
            this.grouppanel.TabIndex = 14;
            this.grouppanel.TabStop = false;
            // 
            // btnalarm
            // 
            this.btnalarm.Location = new System.Drawing.Point(310, 21);
            this.btnalarm.Name = "btnalarm";
            this.btnalarm.Size = new System.Drawing.Size(118, 31);
            this.btnalarm.TabIndex = 11;
            this.btnalarm.Text = "Durdur";
            this.btnalarm.UseVisualStyleBackColor = true;
            this.btnalarm.Click += new System.EventHandler(this.btnalarm_Click);
            // 
            // alarmsimge
            // 
            this.alarmsimge.Image = ((System.Drawing.Image)(resources.GetObject("alarmsimge.Image")));
            this.alarmsimge.Location = new System.Drawing.Point(7, 8);
            this.alarmsimge.Name = "alarmsimge";
            this.alarmsimge.Size = new System.Drawing.Size(46, 44);
            this.alarmsimge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alarmsimge.TabIndex = 10;
            this.alarmsimge.TabStop = false;
            this.alarmsimge.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(1, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 57);
            this.panel1.TabIndex = 2;
            // 
            // labelZaman
            // 
            this.labelZaman.AutoSize = true;
            this.labelZaman.Location = new System.Drawing.Point(59, 29);
            this.labelZaman.Name = "labelZaman";
            this.labelZaman.Size = new System.Drawing.Size(82, 16);
            this.labelZaman.TabIndex = 1;
            this.labelZaman.Text = "Bugün: Saat:";
            // 
            // saatsimge
            // 
            this.saatsimge.Image = ((System.Drawing.Image)(resources.GetObject("saatsimge.Image")));
            this.saatsimge.ImageLocation = "";
            this.saatsimge.Location = new System.Drawing.Point(6, 9);
            this.saatsimge.Name = "saatsimge";
            this.saatsimge.Size = new System.Drawing.Size(47, 44);
            this.saatsimge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saatsimge.TabIndex = 0;
            this.saatsimge.TabStop = false;
            // 
            // timergenel
            // 
            this.timergenel.Tick += new System.EventHandler(this.timergenel_Tick);
            // 
            // timervakitctrl
            // 
            this.timervakitctrl.Tick += new System.EventHandler(this.timervakitctrl_Tick);
            // 
            // timeralarm
            // 
            this.timeralarm.Interval = 1000;
            this.timeralarm.Tick += new System.EventHandler(this.timeralarm_Tick);
            // 
            // MediaPlayer1
            // 
            this.MediaPlayer1.Enabled = true;
            this.MediaPlayer1.Location = new System.Drawing.Point(367, 424);
            this.MediaPlayer1.Name = "MediaPlayer1";
            this.MediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer1.OcxState")));
            this.MediaPlayer1.Size = new System.Drawing.Size(80, 46);
            this.MediaPlayer1.TabIndex = 11;
            // 
            // bildirsim
            // 
            this.bildirsim.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.bildirsim.Icon = ((System.Drawing.Icon)(resources.GetObject("bildirsim.Icon")));
            this.bildirsim.Text = "İş Takibi 1.0.0.1";
            this.bildirsim.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 535);
            this.Controls.Add(this.MediaPlayer1);
            this.Controls.Add(this.grouppanel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelKayit);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHepSil);
            this.Controls.Add(this.btnSecSil);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İş Takibi 1.0.0.1 ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grouppanel.ResumeLayout(false);
            this.grouppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarmsimge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saatsimge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox HatirlaCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textisAdi;
        private System.Windows.Forms.TextBox textAciklama;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnHepSil;
        private System.Windows.Forms.Button btnDuzelt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSecSil;
        private System.Windows.Forms.Label labelKayit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox grouppanel;
        private System.Windows.Forms.Label labelZaman;
        private System.Windows.Forms.PictureBox saatsimge;
        private System.Windows.Forms.Timer timergenel;
        private System.Windows.Forms.Timer timervakitctrl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox alarmsimge;
        private System.Windows.Forms.Timer timeralarm;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer1;
        private System.Windows.Forms.Button btnalarm;
        private System.Windows.Forms.NotifyIcon bildirsim;
    }
}

