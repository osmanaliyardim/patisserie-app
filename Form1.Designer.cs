namespace Pastane_Otomasyon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMalzemeNot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMalzemeFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMalzemeStok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMalzemeAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMalzemeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.txtSFiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunStok = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTarifOlustur = new System.Windows.Forms.Button();
            this.cmbMalzeme = new System.Windows.Forms.ComboBox();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.txtMaliyet = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnMalzemeListesi = new System.Windows.Forms.Button();
            this.btnUrunListesi = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtMalzemeNot);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMalzemeFiyat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMalzemeStok);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMalzemeAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMalzemeID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzeme Stok Giriş";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Malzeme Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMalzemeNot
            // 
            this.txtMalzemeNot.Location = new System.Drawing.Point(128, 285);
            this.txtMalzemeNot.Name = "txtMalzemeNot";
            this.txtMalzemeNot.Size = new System.Drawing.Size(162, 35);
            this.txtMalzemeNot.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "NOT:";
            // 
            // txtMalzemeFiyat
            // 
            this.txtMalzemeFiyat.Location = new System.Drawing.Point(128, 233);
            this.txtMalzemeFiyat.Name = "txtMalzemeFiyat";
            this.txtMalzemeFiyat.Size = new System.Drawing.Size(162, 35);
            this.txtMalzemeFiyat.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "FİYAT:";
            // 
            // txtMalzemeStok
            // 
            this.txtMalzemeStok.Location = new System.Drawing.Point(128, 182);
            this.txtMalzemeStok.Name = "txtMalzemeStok";
            this.txtMalzemeStok.Size = new System.Drawing.Size(162, 35);
            this.txtMalzemeStok.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "STOK:";
            // 
            // txtMalzemeAd
            // 
            this.txtMalzemeAd.Location = new System.Drawing.Point(128, 131);
            this.txtMalzemeAd.Name = "txtMalzemeAd";
            this.txtMalzemeAd.Size = new System.Drawing.Size(162, 35);
            this.txtMalzemeAd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "AD:";
            // 
            // txtMalzemeID
            // 
            this.txtMalzemeID.Enabled = false;
            this.txtMalzemeID.Location = new System.Drawing.Point(128, 81);
            this.txtMalzemeID.Name = "txtMalzemeID";
            this.txtMalzemeID.Size = new System.Drawing.Size(162, 35);
            this.txtMalzemeID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 491);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1149, 399);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Malzemeler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 365);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.btnUrunEkle);
            this.groupBox2.Controls.Add(this.txtSFiyat);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMFiyat);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtUrunStok);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtUrunAd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtUrunID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(397, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 473);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Giriş";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(194, 363);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(143, 43);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(38, 363);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(143, 43);
            this.btnUrunEkle.TabIndex = 10;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtSFiyat
            // 
            this.txtSFiyat.Location = new System.Drawing.Point(147, 285);
            this.txtSFiyat.Name = "txtSFiyat";
            this.txtSFiyat.Size = new System.Drawing.Size(162, 35);
            this.txtSFiyat.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "S.FİYAT:";
            // 
            // txtMFiyat
            // 
            this.txtMFiyat.Location = new System.Drawing.Point(147, 233);
            this.txtMFiyat.Name = "txtMFiyat";
            this.txtMFiyat.Size = new System.Drawing.Size(162, 35);
            this.txtMFiyat.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "M.FİYAT:";
            // 
            // txtUrunStok
            // 
            this.txtUrunStok.Location = new System.Drawing.Point(147, 182);
            this.txtUrunStok.Name = "txtUrunStok";
            this.txtUrunStok.Size = new System.Drawing.Size(162, 35);
            this.txtUrunStok.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 27);
            this.label8.TabIndex = 4;
            this.label8.Text = "STOK:";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(147, 131);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(162, 35);
            this.txtUrunAd.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 27);
            this.label9.TabIndex = 2;
            this.label9.Text = "AD:";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(147, 81);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(162, 35);
            this.txtUrunID.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 27);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTarifOlustur);
            this.groupBox3.Controls.Add(this.cmbMalzeme);
            this.groupBox3.Controls.Add(this.cmbUrun);
            this.groupBox3.Controls.Add(this.txtMaliyet);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtMiktar);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(782, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 473);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Oluştur";
            // 
            // btnTarifOlustur
            // 
            this.btnTarifOlustur.Location = new System.Drawing.Point(161, 322);
            this.btnTarifOlustur.Name = "btnTarifOlustur";
            this.btnTarifOlustur.Size = new System.Drawing.Size(162, 43);
            this.btnTarifOlustur.TabIndex = 12;
            this.btnTarifOlustur.Text = "Ekle";
            this.btnTarifOlustur.UseVisualStyleBackColor = true;
            this.btnTarifOlustur.Click += new System.EventHandler(this.btnTarifOlustur_Click);
            // 
            // cmbMalzeme
            // 
            this.cmbMalzeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMalzeme.FormattingEnabled = true;
            this.cmbMalzeme.Location = new System.Drawing.Point(161, 157);
            this.cmbMalzeme.Name = "cmbMalzeme";
            this.cmbMalzeme.Size = new System.Drawing.Size(162, 35);
            this.cmbMalzeme.TabIndex = 12;
            // 
            // cmbUrun
            // 
            this.cmbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(161, 104);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(162, 35);
            this.cmbUrun.TabIndex = 11;
            // 
            // txtMaliyet
            // 
            this.txtMaliyet.Location = new System.Drawing.Point(161, 256);
            this.txtMaliyet.Name = "txtMaliyet";
            this.txtMaliyet.Size = new System.Drawing.Size(162, 35);
            this.txtMaliyet.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 27);
            this.label12.TabIndex = 6;
            this.label12.Text = "MALİYET:";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(161, 205);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(162, 35);
            this.txtMiktar.TabIndex = 5;
            this.txtMiktar.TextChanged += new System.EventHandler(this.txtMiktar_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 27);
            this.label13.TabIndex = 4;
            this.label13.Text = "MİKTAR:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 27);
            this.label14.TabIndex = 2;
            this.label14.Text = "MALZEME:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(52, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 27);
            this.label15.TabIndex = 0;
            this.label15.Text = "ÜRÜN:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.btnMalzemeListesi);
            this.groupBox5.Controls.Add(this.btnUrunListesi);
            this.groupBox5.Location = new System.Drawing.Point(1167, 491);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(316, 396);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "İşlemler";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(39, 296);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(221, 59);
            this.button9.TabIndex = 3;
            this.button9.Text = "KAPAT";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(39, 221);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(221, 59);
            this.button8.TabIndex = 2;
            this.button8.Text = "KASA";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnMalzemeListesi
            // 
            this.btnMalzemeListesi.Location = new System.Drawing.Point(39, 146);
            this.btnMalzemeListesi.Name = "btnMalzemeListesi";
            this.btnMalzemeListesi.Size = new System.Drawing.Size(221, 59);
            this.btnMalzemeListesi.TabIndex = 1;
            this.btnMalzemeListesi.Text = "MALZEMELER";
            this.btnMalzemeListesi.UseVisualStyleBackColor = true;
            this.btnMalzemeListesi.Click += new System.EventHandler(this.btnMalzemeListesi_Click);
            // 
            // btnUrunListesi
            // 
            this.btnUrunListesi.Location = new System.Drawing.Point(39, 71);
            this.btnUrunListesi.Name = "btnUrunListesi";
            this.btnUrunListesi.Size = new System.Drawing.Size(221, 59);
            this.btnUrunListesi.TabIndex = 0;
            this.btnUrunListesi.Text = "ÜRÜN LİSTESİ";
            this.btnUrunListesi.UseVisualStyleBackColor = true;
            this.btnUrunListesi.Click += new System.EventHandler(this.btnUrunListesi_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listBox1);
            this.groupBox6.Location = new System.Drawing.Point(1167, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(319, 473);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ürünler - Fiyat";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Location = new System.Drawing.Point(3, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 439);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1501, 902);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMalzemeNot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMalzemeFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMalzemeStok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMalzemeAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMalzemeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TextBox txtSFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunStok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaliyet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnMalzemeListesi;
        private System.Windows.Forms.Button btnUrunListesi;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbMalzeme;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.Button btnTarifOlustur;
    }
}

