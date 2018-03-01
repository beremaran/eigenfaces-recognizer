namespace YuzTanima
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tablar = new System.Windows.Forms.TabControl();
            this.tabKisiler = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFotografEkle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picOnizleme = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFotografSil = new System.Windows.Forms.Button();
            this.txtDosyaAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listKisiFotograflar = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYeniKisi = new System.Windows.Forms.Button();
            this.btnKisiSil = new System.Windows.Forms.Button();
            this.listKisiler = new System.Windows.Forms.ListBox();
            this.tabTahmin = new System.Windows.Forms.TabPage();
            this.tabEgitim = new System.Windows.Forms.TabPage();
            this.progressEgitim = new System.Windows.Forms.ProgressBar();
            this.txtProgress = new System.Windows.Forms.Label();
            this.txtEgitimLog = new System.Windows.Forms.TextBox();
            this.btnEgitimBaslat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDosyaYukle = new System.Windows.Forms.Button();
            this.btnKameradanYukle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picHamImaj = new System.Windows.Forms.PictureBox();
            this.tablar.SuspendLayout();
            this.tabKisiler.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOnizleme)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabTahmin.SuspendLayout();
            this.tabEgitim.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHamImaj)).BeginInit();
            this.SuspendLayout();
            // 
            // tablar
            // 
            this.tablar.Controls.Add(this.tabKisiler);
            this.tablar.Controls.Add(this.tabEgitim);
            this.tablar.Controls.Add(this.tabTahmin);
            this.tablar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablar.Location = new System.Drawing.Point(0, 0);
            this.tablar.Name = "tablar";
            this.tablar.SelectedIndex = 0;
            this.tablar.Size = new System.Drawing.Size(784, 562);
            this.tablar.TabIndex = 0;
            // 
            // tabKisiler
            // 
            this.tabKisiler.Controls.Add(this.groupBox2);
            this.tabKisiler.Controls.Add(this.groupBox1);
            this.tabKisiler.Location = new System.Drawing.Point(4, 22);
            this.tabKisiler.Name = "tabKisiler";
            this.tabKisiler.Padding = new System.Windows.Forms.Padding(3);
            this.tabKisiler.Size = new System.Drawing.Size(776, 536);
            this.tabKisiler.TabIndex = 0;
            this.tabKisiler.Text = "Kişiler";
            this.tabKisiler.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnFotografEkle);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.listKisiFotograflar);
            this.groupBox2.Location = new System.Drawing.Point(257, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 524);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fotoğraflar";
            // 
            // btnFotografEkle
            // 
            this.btnFotografEkle.Location = new System.Drawing.Point(6, 489);
            this.btnFotografEkle.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnFotografEkle.Name = "btnFotografEkle";
            this.btnFotografEkle.Size = new System.Drawing.Size(245, 29);
            this.btnFotografEkle.TabIndex = 4;
            this.btnFotografEkle.Text = "Kişiye Fotoğraf Ekle";
            this.btnFotografEkle.UseVisualStyleBackColor = false;
            this.btnFotografEkle.Click += new System.EventHandler(this.btnFotografEkle_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.picOnizleme, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(257, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(251, 505);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // picOnizleme
            // 
            this.picOnizleme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picOnizleme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picOnizleme.Image = global::YuzTanima.Properties.Resources.bos;
            this.picOnizleme.ImageLocation = "";
            this.picOnizleme.Location = new System.Drawing.Point(3, 3);
            this.picOnizleme.Name = "picOnizleme";
            this.picOnizleme.Size = new System.Drawing.Size(245, 246);
            this.picOnizleme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOnizleme.TabIndex = 0;
            this.picOnizleme.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFotografSil);
            this.panel1.Controls.Add(this.txtDosyaAdi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 247);
            this.panel1.TabIndex = 1;
            // 
            // btnFotografSil
            // 
            this.btnFotografSil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFotografSil.Location = new System.Drawing.Point(0, 218);
            this.btnFotografSil.Name = "btnFotografSil";
            this.btnFotografSil.Size = new System.Drawing.Size(245, 29);
            this.btnFotografSil.TabIndex = 3;
            this.btnFotografSil.Text = "Fotoğrafı Sil";
            this.btnFotografSil.UseVisualStyleBackColor = false;
            this.btnFotografSil.Click += new System.EventHandler(this.btnFotografSil_Click);
            // 
            // txtDosyaAdi
            // 
            this.txtDosyaAdi.AutoSize = true;
            this.txtDosyaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDosyaAdi.Location = new System.Drawing.Point(3, 20);
            this.txtDosyaAdi.Name = "txtDosyaAdi";
            this.txtDosyaAdi.Size = new System.Drawing.Size(57, 16);
            this.txtDosyaAdi.TabIndex = 1;
            this.txtDosyaAdi.Text = "bos.png";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya Adı";
            // 
            // listKisiFotograflar
            // 
            this.listKisiFotograflar.FormattingEnabled = true;
            this.listKisiFotograflar.Location = new System.Drawing.Point(6, 19);
            this.listKisiFotograflar.Name = "listKisiFotograflar";
            this.listKisiFotograflar.Size = new System.Drawing.Size(245, 459);
            this.listKisiFotograflar.TabIndex = 0;
            this.listKisiFotograflar.SelectedIndexChanged += new System.EventHandler(this.listKisiFotograflar_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnYeniKisi);
            this.groupBox1.Controls.Add(this.btnKisiSil);
            this.groupBox1.Controls.Add(this.listKisiler);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişiler";
            // 
            // btnYeniKisi
            // 
            this.btnYeniKisi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnYeniKisi.Location = new System.Drawing.Point(3, 463);
            this.btnYeniKisi.Name = "btnYeniKisi";
            this.btnYeniKisi.Size = new System.Drawing.Size(237, 29);
            this.btnYeniKisi.TabIndex = 5;
            this.btnYeniKisi.Text = "Yeni Kişi Oluştur";
            this.btnYeniKisi.UseVisualStyleBackColor = false;
            this.btnYeniKisi.Click += new System.EventHandler(this.btnYeniKisi_Click);
            // 
            // btnKisiSil
            // 
            this.btnKisiSil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKisiSil.Location = new System.Drawing.Point(3, 492);
            this.btnKisiSil.Name = "btnKisiSil";
            this.btnKisiSil.Size = new System.Drawing.Size(237, 29);
            this.btnKisiSil.TabIndex = 4;
            this.btnKisiSil.Text = "Seçili Kişiyi Sil";
            this.btnKisiSil.UseVisualStyleBackColor = false;
            this.btnKisiSil.Click += new System.EventHandler(this.btnKisiSil_Click);
            // 
            // listKisiler
            // 
            this.listKisiler.FormattingEnabled = true;
            this.listKisiler.Location = new System.Drawing.Point(6, 19);
            this.listKisiler.Name = "listKisiler";
            this.listKisiler.Size = new System.Drawing.Size(231, 433);
            this.listKisiler.TabIndex = 0;
            this.listKisiler.SelectedIndexChanged += new System.EventHandler(this.listKisiler_SelectedIndexChanged);
            // 
            // tabTahmin
            // 
            this.tabTahmin.Controls.Add(this.picHamImaj);
            this.tabTahmin.Controls.Add(this.groupBox3);
            this.tabTahmin.Location = new System.Drawing.Point(4, 22);
            this.tabTahmin.Name = "tabTahmin";
            this.tabTahmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabTahmin.Size = new System.Drawing.Size(776, 536);
            this.tabTahmin.TabIndex = 1;
            this.tabTahmin.Text = "Tanıla";
            this.tabTahmin.UseVisualStyleBackColor = true;
            // 
            // tabEgitim
            // 
            this.tabEgitim.Controls.Add(this.btnEgitimBaslat);
            this.tabEgitim.Controls.Add(this.txtEgitimLog);
            this.tabEgitim.Controls.Add(this.txtProgress);
            this.tabEgitim.Controls.Add(this.progressEgitim);
            this.tabEgitim.Location = new System.Drawing.Point(4, 22);
            this.tabEgitim.Name = "tabEgitim";
            this.tabEgitim.Padding = new System.Windows.Forms.Padding(3);
            this.tabEgitim.Size = new System.Drawing.Size(776, 536);
            this.tabEgitim.TabIndex = 2;
            this.tabEgitim.Text = "Eğitim";
            this.tabEgitim.UseVisualStyleBackColor = true;
            // 
            // progressEgitim
            // 
            this.progressEgitim.Location = new System.Drawing.Point(8, 6);
            this.progressEgitim.Name = "progressEgitim";
            this.progressEgitim.Size = new System.Drawing.Size(593, 23);
            this.progressEgitim.Step = 1;
            this.progressEgitim.TabIndex = 0;
            // 
            // txtProgress
            // 
            this.txtProgress.AutoSize = true;
            this.txtProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProgress.Location = new System.Drawing.Point(607, 9);
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.Size = new System.Drawing.Size(41, 16);
            this.txtProgress.TabIndex = 1;
            this.txtProgress.Text = "100%";
            // 
            // txtEgitimLog
            // 
            this.txtEgitimLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEgitimLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtEgitimLog.Location = new System.Drawing.Point(3, 35);
            this.txtEgitimLog.Multiline = true;
            this.txtEgitimLog.Name = "txtEgitimLog";
            this.txtEgitimLog.ReadOnly = true;
            this.txtEgitimLog.Size = new System.Drawing.Size(770, 498);
            this.txtEgitimLog.TabIndex = 2;
            this.txtEgitimLog.Text = "\"Kişiler\" sekmesinde belirlenen kişi ve fotoğraflar ile Eigen yüz detektörü eğiti" +
    "lecek.\r\n\r\nEğitimi başlatmak için \"Eğitimi Başlat\" butonuna tıklayın.";
            // 
            // btnEgitimBaslat
            // 
            this.btnEgitimBaslat.Location = new System.Drawing.Point(654, 6);
            this.btnEgitimBaslat.Name = "btnEgitimBaslat";
            this.btnEgitimBaslat.Size = new System.Drawing.Size(116, 23);
            this.btnEgitimBaslat.TabIndex = 3;
            this.btnEgitimBaslat.Text = "Eğitimi Başlat";
            this.btnEgitimBaslat.UseVisualStyleBackColor = true;
            this.btnEgitimBaslat.Click += new System.EventHandler(this.btnEgitimBaslat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnKameradanYukle);
            this.groupBox3.Controls.Add(this.btnDosyaYukle);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 56);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fotoğraf Yükle";
            // 
            // btnDosyaYukle
            // 
            this.btnDosyaYukle.Location = new System.Drawing.Point(6, 19);
            this.btnDosyaYukle.Name = "btnDosyaYukle";
            this.btnDosyaYukle.Size = new System.Drawing.Size(119, 23);
            this.btnDosyaYukle.TabIndex = 0;
            this.btnDosyaYukle.Text = "Dosyadan Tek Kare";
            this.btnDosyaYukle.UseVisualStyleBackColor = true;
            this.btnDosyaYukle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKameradanYukle
            // 
            this.btnKameradanYukle.Location = new System.Drawing.Point(131, 19);
            this.btnKameradanYukle.Name = "btnKameradanYukle";
            this.btnKameradanYukle.Size = new System.Drawing.Size(119, 23);
            this.btnKameradanYukle.TabIndex = 1;
            this.btnKameradanYukle.Text = "Kameradan Tek Kare";
            this.btnKameradanYukle.UseVisualStyleBackColor = true;
            this.btnKameradanYukle.Click += new System.EventHandler(this.btnKameradanYukle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kameradan Canlı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picHamImaj
            // 
            this.picHamImaj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picHamImaj.Location = new System.Drawing.Point(3, 73);
            this.picHamImaj.Name = "picHamImaj";
            this.picHamImaj.Size = new System.Drawing.Size(770, 460);
            this.picHamImaj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHamImaj.TabIndex = 2;
            this.picHamImaj.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tablar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Yüz Tanıma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tablar.ResumeLayout(false);
            this.tabKisiler.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOnizleme)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabTahmin.ResumeLayout(false);
            this.tabEgitim.ResumeLayout(false);
            this.tabEgitim.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHamImaj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tablar;
        private System.Windows.Forms.TabPage tabKisiler;
        private System.Windows.Forms.TabPage tabTahmin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listKisiFotograflar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picOnizleme;
        private System.Windows.Forms.ListBox listKisiler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtDosyaAdi;
        private System.Windows.Forms.Button btnFotografSil;
        private System.Windows.Forms.Button btnKisiSil;
        private System.Windows.Forms.Button btnYeniKisi;
        private System.Windows.Forms.Button btnFotografEkle;
        private System.Windows.Forms.TabPage tabEgitim;
        private System.Windows.Forms.ProgressBar progressEgitim;
        private System.Windows.Forms.Label txtProgress;
        private System.Windows.Forms.TextBox txtEgitimLog;
        private System.Windows.Forms.Button btnEgitimBaslat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKameradanYukle;
        private System.Windows.Forms.Button btnDosyaYukle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picHamImaj;
    }
}

