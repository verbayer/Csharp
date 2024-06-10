namespace WindowsFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textGuncelBorc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textUcret = new System.Windows.Forms.TextBox();
            this.textOdeme = new System.Windows.Forms.TextBox();
            this.comboFakulte = new System.Windows.Forms.ComboBox();
            this.comboSehir = new System.Windows.Forms.ComboBox();
            this.comboBurs = new System.Windows.Forms.ComboBox();
            this.maskedTextTC = new System.Windows.Forms.MaskedTextBox();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.textOgrNo = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblogrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._uni_kayitDataSet = new WindowsFormsApp1._uni_kayitDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.tbl_ogrTableAdapter = new WindowsFormsApp1._uni_kayitDataSetTableAdapters.tbl_ogrTableAdapter();
            this._uni_kayitDataSet1 = new WindowsFormsApp1._uni_kayitDataSet1();
            this.tblogrBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ogrTableAdapter1 = new WindowsFormsApp1._uni_kayitDataSet1TableAdapters.tbl_ogrTableAdapter();
            this.unikayitDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblogrBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblogrBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.unikayitDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblogrBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this._uni_kayitDataSet3 = new WindowsFormsApp1._uni_kayitDataSet3();
            this.tblogrBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl__ogrTableAdapter = new WindowsFormsApp1._uni_kayitDataSet3TableAdapters.tbl__ogrTableAdapter();
            this.ogrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCKNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fakulteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuncelBorc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._uni_kayitDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._uni_kayitDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unikayitDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unikayitDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._uni_kayitDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.textGuncelBorc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textUcret);
            this.groupBox1.Controls.Add(this.textOdeme);
            this.groupBox1.Controls.Add(this.comboFakulte);
            this.groupBox1.Controls.Add(this.comboSehir);
            this.groupBox1.Controls.Add(this.comboBurs);
            this.groupBox1.Controls.Add(this.maskedTextTC);
            this.groupBox1.Controls.Add(this.textSoyad);
            this.groupBox1.Controls.Add(this.textOgrNo);
            this.groupBox1.Controls.Add(this.textAd);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÖĞRENCİ BİLGİLERİ";
            // 
            // textGuncelBorc
            // 
            this.textGuncelBorc.Location = new System.Drawing.Point(334, 359);
            this.textGuncelBorc.Name = "textGuncelBorc";
            this.textGuncelBorc.Size = new System.Drawing.Size(192, 22);
            this.textGuncelBorc.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 888889;
            this.label10.Text = "Güncel Borç";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textUcret
            // 
            this.textUcret.Location = new System.Drawing.Point(475, 239);
            this.textUcret.Name = "textUcret";
            this.textUcret.Size = new System.Drawing.Size(192, 22);
            this.textUcret.TabIndex = 7;
            // 
            // textOdeme
            // 
            this.textOdeme.Location = new System.Drawing.Point(475, 316);
            this.textOdeme.Name = "textOdeme";
            this.textOdeme.Size = new System.Drawing.Size(192, 22);
            this.textOdeme.TabIndex = 8;
            this.textOdeme.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // comboFakulte
            // 
            this.comboFakulte.FormattingEnabled = true;
            this.comboFakulte.Items.AddRange(new object[] {
            "Mühendislik ve Mimarlık F.",
            "Güzel Sanatlar F.",
            "Meslek Yüksekokulu",
            "Eğitim Fakültesi"});
            this.comboFakulte.Location = new System.Drawing.Point(475, 154);
            this.comboFakulte.Name = "comboFakulte";
            this.comboFakulte.Size = new System.Drawing.Size(192, 24);
            this.comboFakulte.TabIndex = 6;
            // 
            // comboSehir
            // 
            this.comboSehir.FormattingEnabled = true;
            this.comboSehir.Items.AddRange(new object[] {
            "İstanbul",
            "Adana",
            "Ankara",
            "Eskişehir",
            "İzmir",
            "Bursa"});
            this.comboSehir.Location = new System.Drawing.Point(101, 314);
            this.comboSehir.Name = "comboSehir";
            this.comboSehir.Size = new System.Drawing.Size(216, 24);
            this.comboSehir.TabIndex = 4;
            // 
            // comboBurs
            // 
            this.comboBurs.FormattingEnabled = true;
            this.comboBurs.Items.AddRange(new object[] {
            "25",
            "50",
            "75",
            "100"});
            this.comboBurs.Location = new System.Drawing.Point(475, 67);
            this.comboBurs.Name = "comboBurs";
            this.comboBurs.Size = new System.Drawing.Size(192, 24);
            this.comboBurs.TabIndex = 5;
            this.comboBurs.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // maskedTextTC
            // 
            this.maskedTextTC.Location = new System.Drawing.Point(101, 245);
            this.maskedTextTC.Mask = "00000000000";
            this.maskedTextTC.Name = "maskedTextTC";
            this.maskedTextTC.Size = new System.Drawing.Size(216, 22);
            this.maskedTextTC.TabIndex = 3;
            this.maskedTextTC.ValidatingType = typeof(int);
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(101, 177);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(216, 22);
            this.textSoyad.TabIndex = 2;
            this.textSoyad.TextChanged += new System.EventHandler(this.textSoyad_TextChanged);
            // 
            // textOgrNo
            // 
            this.textOgrNo.Location = new System.Drawing.Point(101, 52);
            this.textOgrNo.Name = "textOgrNo";
            this.textOgrNo.Size = new System.Drawing.Size(216, 22);
            this.textOgrNo.TabIndex = 0;
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(101, 118);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(216, 22);
            this.textAd.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 77565;
            this.label9.Text = "Ödeme";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 55585;
            this.label8.Text = "Ücreti";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 7778;
            this.label7.Text = "Fakülte";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 46567;
            this.label6.Text = "Burs Miktarı";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 77777;
            this.label5.Text = "Şehir";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 88888;
            this.label4.Text = "TCKN";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 888888;
            this.label3.Text = "Öğrenci No:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 555858;
            this.label2.Text = "Soyadı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 54654;
            this.label1.Text = "Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(832, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 563);
            this.groupBox2.TabIndex = 999999;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BİLGİLER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrNo,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.sehirDataGridViewTextBoxColumn,
            this.tCKNDataGridViewTextBoxColumn,
            this.bursDataGridViewTextBoxColumn,
            this.fakulteDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn,
            this.odemeDataGridViewTextBoxColumn,
            this.GuncelBorc});
            this.dataGridView1.DataSource = this.tblogrBindingSource5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(497, 542);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tblogrBindingSource
            // 
            this.tblogrBindingSource.DataMember = "tbl_ogr";
            this.tblogrBindingSource.DataSource = this._uni_kayitDataSet;
            // 
            // _uni_kayitDataSet
            // 
            this._uni_kayitDataSet.DataSetName = "_uni_kayitDataSet";
            this._uni_kayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnListele);
            this.groupBox3.Controls.Add(this.btnGuncelle);
            this.groupBox3.Controls.Add(this.btnEkle);
            this.groupBox3.Controls.Add(this.btnSil);
            this.groupBox3.Location = new System.Drawing.Point(12, 438);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(797, 137);
            this.groupBox3.TabIndex = 8888548;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BUTONLAR";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(636, 21);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(135, 100);
            this.btnListele.TabIndex = 12;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(446, 22);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(139, 100);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(248, 21);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(143, 100);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(43, 22);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(144, 100);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // tbl_ogrTableAdapter
            // 
            this.tbl_ogrTableAdapter.ClearBeforeFill = true;
            // 
            // _uni_kayitDataSet1
            // 
            this._uni_kayitDataSet1.DataSetName = "_uni_kayitDataSet1";
            this._uni_kayitDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblogrBindingSource1
            // 
            this.tblogrBindingSource1.DataMember = "tbl_ogr";
            this.tblogrBindingSource1.DataSource = this._uni_kayitDataSet1;
            // 
            // tbl_ogrTableAdapter1
            // 
            this.tbl_ogrTableAdapter1.ClearBeforeFill = true;
            // 
            // unikayitDataSet1BindingSource
            // 
            this.unikayitDataSet1BindingSource.DataSource = this._uni_kayitDataSet1;
            this.unikayitDataSet1BindingSource.Position = 0;
            // 
            // tblogrBindingSource2
            // 
            this.tblogrBindingSource2.DataMember = "tbl_ogr";
            this.tblogrBindingSource2.DataSource = this.unikayitDataSet1BindingSource;
            // 
            // tblogrBindingSource3
            // 
            this.tblogrBindingSource3.DataMember = "tbl_ogr";
            this.tblogrBindingSource3.DataSource = this.unikayitDataSet1BindingSource;
            // 
            // unikayitDataSetBindingSource
            // 
            this.unikayitDataSetBindingSource.DataSource = this._uni_kayitDataSet;
            this.unikayitDataSetBindingSource.Position = 0;
            // 
            // tblogrBindingSource4
            // 
            this.tblogrBindingSource4.DataMember = "tbl_ogr";
            this.tblogrBindingSource4.DataSource = this.unikayitDataSetBindingSource;
            // 
            // _uni_kayitDataSet3
            // 
            this._uni_kayitDataSet3.DataSetName = "_uni_kayitDataSet3";
            this._uni_kayitDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblogrBindingSource5
            // 
            this.tblogrBindingSource5.DataMember = "tbl__ogr";
            this.tblogrBindingSource5.DataSource = this._uni_kayitDataSet3;
            // 
            // tbl__ogrTableAdapter
            // 
            this.tbl__ogrTableAdapter.ClearBeforeFill = true;
            // 
            // ogrNo
            // 
            this.ogrNo.DataPropertyName = "ogrNo";
            this.ogrNo.HeaderText = "ogrNo";
            this.ogrNo.MinimumWidth = 6;
            this.ogrNo.Name = "ogrNo";
            this.ogrNo.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // sehirDataGridViewTextBoxColumn
            // 
            this.sehirDataGridViewTextBoxColumn.DataPropertyName = "Sehir";
            this.sehirDataGridViewTextBoxColumn.HeaderText = "Sehir";
            this.sehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sehirDataGridViewTextBoxColumn.Name = "sehirDataGridViewTextBoxColumn";
            this.sehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // tCKNDataGridViewTextBoxColumn
            // 
            this.tCKNDataGridViewTextBoxColumn.DataPropertyName = "TCKN";
            this.tCKNDataGridViewTextBoxColumn.HeaderText = "TCKN";
            this.tCKNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tCKNDataGridViewTextBoxColumn.Name = "tCKNDataGridViewTextBoxColumn";
            this.tCKNDataGridViewTextBoxColumn.Width = 125;
            // 
            // bursDataGridViewTextBoxColumn
            // 
            this.bursDataGridViewTextBoxColumn.DataPropertyName = "Burs";
            this.bursDataGridViewTextBoxColumn.HeaderText = "Burs";
            this.bursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bursDataGridViewTextBoxColumn.Name = "bursDataGridViewTextBoxColumn";
            this.bursDataGridViewTextBoxColumn.Width = 125;
            // 
            // fakulteDataGridViewTextBoxColumn
            // 
            this.fakulteDataGridViewTextBoxColumn.DataPropertyName = "Fakulte";
            this.fakulteDataGridViewTextBoxColumn.HeaderText = "Fakulte";
            this.fakulteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fakulteDataGridViewTextBoxColumn.Name = "fakulteDataGridViewTextBoxColumn";
            this.fakulteDataGridViewTextBoxColumn.Width = 125;
            // 
            // ucretDataGridViewTextBoxColumn
            // 
            this.ucretDataGridViewTextBoxColumn.DataPropertyName = "Ucret";
            this.ucretDataGridViewTextBoxColumn.HeaderText = "Ucret";
            this.ucretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
            this.ucretDataGridViewTextBoxColumn.Width = 125;
            // 
            // odemeDataGridViewTextBoxColumn
            // 
            this.odemeDataGridViewTextBoxColumn.DataPropertyName = "Odeme";
            this.odemeDataGridViewTextBoxColumn.HeaderText = "Odeme";
            this.odemeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odemeDataGridViewTextBoxColumn.Name = "odemeDataGridViewTextBoxColumn";
            this.odemeDataGridViewTextBoxColumn.Width = 125;
            // 
            // GuncelBorc
            // 
            this.GuncelBorc.DataPropertyName = "GuncelBorc";
            this.GuncelBorc.HeaderText = "GuncelBorc";
            this.GuncelBorc.MinimumWidth = 6;
            this.GuncelBorc.Name = "GuncelBorc";
            this.GuncelBorc.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1347, 587);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Öğrenci Ödeme Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._uni_kayitDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._uni_kayitDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unikayitDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unikayitDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._uni_kayitDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrBindingSource5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextTC;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.TextBox textOgrNo;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.ComboBox comboSehir;
        private System.Windows.Forms.ComboBox comboBurs;
        private System.Windows.Forms.ComboBox comboFakulte;
        private System.Windows.Forms.TextBox textUcret;
        private System.Windows.Forms.TextBox textOdeme;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _uni_kayitDataSet _uni_kayitDataSet;
        private System.Windows.Forms.BindingSource tblogrBindingSource;
        private _uni_kayitDataSetTableAdapters.tbl_ogrTableAdapter tbl_ogrTableAdapter;
        private _uni_kayitDataSet1 _uni_kayitDataSet1;
        private System.Windows.Forms.BindingSource tblogrBindingSource1;
        private _uni_kayitDataSet1TableAdapters.tbl_ogrTableAdapter tbl_ogrTableAdapter1;
        private System.Windows.Forms.TextBox textGuncelBorc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource tblogrBindingSource2;
        private System.Windows.Forms.BindingSource unikayitDataSet1BindingSource;
        private System.Windows.Forms.BindingSource tblogrBindingSource4;
        private System.Windows.Forms.BindingSource unikayitDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblogrBindingSource3;
        private _uni_kayitDataSet3 _uni_kayitDataSet3;
        private System.Windows.Forms.BindingSource tblogrBindingSource5;
        private _uni_kayitDataSet3TableAdapters.tbl__ogrTableAdapter tbl__ogrTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCKNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fakulteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuncelBorc;
    }
}

