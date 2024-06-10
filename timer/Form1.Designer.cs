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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtBoxIstenensure = new System.Windows.Forms.TextBox();
            this.devambuton = new System.Windows.Forms.Button();
            this.durdurbuton = new System.Windows.Forms.Button();
            this.baslabuton = new System.Windows.Forms.Button();
            this.txtgerisayim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGecensure = new System.Windows.Forms.Label();
            this.txtSistemsure = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.txtBoxIstenensure);
            this.groupBox1.Controls.Add(this.devambuton);
            this.groupBox1.Controls.Add(this.durdurbuton);
            this.groupBox1.Controls.Add(this.baslabuton);
            this.groupBox1.Controls.Add(this.txtgerisayim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Süre belirtin";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.SpringGreen;
            this.progressBar1.Location = new System.Drawing.Point(24, 248);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(256, 32);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            // 
            // txtBoxIstenensure
            // 
            this.txtBoxIstenensure.Location = new System.Drawing.Point(77, 39);
            this.txtBoxIstenensure.Name = "txtBoxIstenensure";
            this.txtBoxIstenensure.Size = new System.Drawing.Size(47, 22);
            this.txtBoxIstenensure.TabIndex = 7;
            // 
            // devambuton
            // 
            this.devambuton.BackColor = System.Drawing.Color.LimeGreen;
            this.devambuton.Location = new System.Drawing.Point(23, 334);
            this.devambuton.Name = "devambuton";
            this.devambuton.Size = new System.Drawing.Size(257, 32);
            this.devambuton.TabIndex = 6;
            this.devambuton.Text = "Devam Et";
            this.devambuton.UseVisualStyleBackColor = false;
            this.devambuton.Click += new System.EventHandler(this.devambuton_Click);
            // 
            // durdurbuton
            // 
            this.durdurbuton.BackColor = System.Drawing.Color.LightGreen;
            this.durdurbuton.Location = new System.Drawing.Point(23, 296);
            this.durdurbuton.Name = "durdurbuton";
            this.durdurbuton.Size = new System.Drawing.Size(257, 32);
            this.durdurbuton.TabIndex = 5;
            this.durdurbuton.Text = "Durdur";
            this.durdurbuton.UseVisualStyleBackColor = false;
            this.durdurbuton.Click += new System.EventHandler(this.durdurbuton_Click);
            // 
            // baslabuton
            // 
            this.baslabuton.BackColor = System.Drawing.Color.LimeGreen;
            this.baslabuton.Location = new System.Drawing.Point(23, 90);
            this.baslabuton.Name = "baslabuton";
            this.baslabuton.Size = new System.Drawing.Size(257, 32);
            this.baslabuton.TabIndex = 4;
            this.baslabuton.Text = "Başlat";
            this.baslabuton.UseVisualStyleBackColor = false;
            this.baslabuton.Click += new System.EventHandler(this.baslabuton_Click);
            // 
            // txtgerisayim
            // 
            this.txtgerisayim.AutoSize = true;
            this.txtgerisayim.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtgerisayim.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgerisayim.Location = new System.Drawing.Point(26, 141);
            this.txtgerisayim.Name = "txtgerisayim";
            this.txtgerisayim.Size = new System.Drawing.Size(237, 91);
            this.txtgerisayim.TabIndex = 1;
            this.txtgerisayim.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dakika";
            // 
            // txtGecensure
            // 
            this.txtGecensure.AutoSize = true;
            this.txtGecensure.Location = new System.Drawing.Point(12, 412);
            this.txtGecensure.Name = "txtGecensure";
            this.txtGecensure.Size = new System.Drawing.Size(38, 16);
            this.txtGecensure.TabIndex = 2;
            this.txtGecensure.Text = "00:00";
            // 
            // txtSistemsure
            // 
            this.txtSistemsure.AutoSize = true;
            this.txtSistemsure.Location = new System.Drawing.Point(245, 412);
            this.txtSistemsure.Name = "txtSistemsure";
            this.txtSistemsure.Size = new System.Drawing.Size(75, 16);
            this.txtSistemsure.TabIndex = 3;
            this.txtSistemsure.Text = "sistem saat";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 450);
            this.Controls.Add(this.txtSistemsure);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtGecensure);
            this.Name = "Form1";
            this.Text = "Zamanlayıcı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtgerisayim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtGecensure;
        private System.Windows.Forms.Label txtSistemsure;
        private System.Windows.Forms.Button devambuton;
        private System.Windows.Forms.Button durdurbuton;
        private System.Windows.Forms.Button baslabuton;
        private System.Windows.Forms.TextBox txtBoxIstenensure;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

