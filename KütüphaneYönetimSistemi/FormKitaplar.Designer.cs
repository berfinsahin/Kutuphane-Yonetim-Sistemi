namespace KütüphaneYönetimSistemi
{
    partial class FormKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitaplar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonKitapEkle = new System.Windows.Forms.Button();
            this.buttonKitapBilgiGuncelle = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonTumKıtaplarıGoster = new System.Windows.Forms.Button();
            this.buttonAra = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.textBoxKitapTurKodu = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxYazarSoyad = new System.Windows.Forms.TextBox();
            this.textBoxYazarAdi = new System.Windows.Forms.TextBox();
            this.textBoxKitapAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonKitapOduncVer = new System.Windows.Forms.Button();
            this.dateTimePickerOduncAlmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.textBoxOduncAlan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonKitabiIadeEt = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.labelGecikmeBedeli = new System.Windows.Forms.Label();
            this.buttonGecikmeBedeliHesapla = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewKitaplar = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.textBoxKitapTurKodu);
            this.groupBox1.Controls.Add(this.textBoxISBN);
            this.groupBox1.Controls.Add(this.textBoxYazarSoyad);
            this.groupBox1.Controls.Add(this.textBoxYazarAdi);
            this.groupBox1.Controls.Add(this.textBoxKitapAdi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Kayıt ve Güncelleme";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox6.Controls.Add(this.buttonSil);
            this.groupBox6.Controls.Add(this.buttonKitapEkle);
            this.groupBox6.Controls.Add(this.buttonKitapBilgiGuncelle);
            this.groupBox6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(0, 354);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(462, 130);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kayıt Düzenleme İşlemleri";
            // 
            // buttonSil
            // 
            this.buttonSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSil.BackgroundImage")));
            this.buttonSil.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSil.ForeColor = System.Drawing.Color.White;
            this.buttonSil.Location = new System.Drawing.Point(314, 38);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(145, 65);
            this.buttonSil.TabIndex = 17;
            this.buttonSil.Text = "Kitap Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonKitapEkle
            // 
            this.buttonKitapEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonKitapEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonKitapEkle.BackgroundImage")));
            this.buttonKitapEkle.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonKitapEkle.ForeColor = System.Drawing.Color.White;
            this.buttonKitapEkle.Location = new System.Drawing.Point(162, 38);
            this.buttonKitapEkle.Name = "buttonKitapEkle";
            this.buttonKitapEkle.Size = new System.Drawing.Size(145, 65);
            this.buttonKitapEkle.TabIndex = 12;
            this.buttonKitapEkle.Text = "Yeni Kitap Ekle";
            this.buttonKitapEkle.UseVisualStyleBackColor = true;
            this.buttonKitapEkle.Click += new System.EventHandler(this.buttonKitapEkle_Click);
            // 
            // buttonKitapBilgiGuncelle
            // 
            this.buttonKitapBilgiGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonKitapBilgiGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonKitapBilgiGuncelle.BackgroundImage")));
            this.buttonKitapBilgiGuncelle.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonKitapBilgiGuncelle.ForeColor = System.Drawing.Color.White;
            this.buttonKitapBilgiGuncelle.Location = new System.Drawing.Point(6, 38);
            this.buttonKitapBilgiGuncelle.Name = "buttonKitapBilgiGuncelle";
            this.buttonKitapBilgiGuncelle.Size = new System.Drawing.Size(150, 65);
            this.buttonKitapBilgiGuncelle.TabIndex = 13;
            this.buttonKitapBilgiGuncelle.Text = "Kitap Bilgileri Güncelle";
            this.buttonKitapBilgiGuncelle.UseVisualStyleBackColor = true;
            this.buttonKitapBilgiGuncelle.Click += new System.EventHandler(this.buttonKitapBilgiGuncelle_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.buttonTumKıtaplarıGoster);
            this.groupBox5.Controls.Add(this.buttonAra);
            this.groupBox5.Controls.Add(this.buttonTemizle);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(477, 354);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(471, 130);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Arama";
            // 
            // buttonTumKıtaplarıGoster
            // 
            this.buttonTumKıtaplarıGoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTumKıtaplarıGoster.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTumKıtaplarıGoster.BackgroundImage")));
            this.buttonTumKıtaplarıGoster.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTumKıtaplarıGoster.ForeColor = System.Drawing.Color.White;
            this.buttonTumKıtaplarıGoster.Location = new System.Drawing.Point(308, 38);
            this.buttonTumKıtaplarıGoster.Name = "buttonTumKıtaplarıGoster";
            this.buttonTumKıtaplarıGoster.Size = new System.Drawing.Size(156, 65);
            this.buttonTumKıtaplarıGoster.TabIndex = 16;
            this.buttonTumKıtaplarıGoster.Text = "Tüm Kitapları Göster";
            this.buttonTumKıtaplarıGoster.UseVisualStyleBackColor = true;
            this.buttonTumKıtaplarıGoster.Click += new System.EventHandler(this.buttonTumKıtaplarıGoster_Click);
            // 
            // buttonAra
            // 
            this.buttonAra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAra.BackgroundImage")));
            this.buttonAra.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAra.ForeColor = System.Drawing.Color.White;
            this.buttonAra.Location = new System.Drawing.Point(157, 38);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(145, 65);
            this.buttonAra.TabIndex = 15;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTemizle.BackgroundImage")));
            this.buttonTemizle.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTemizle.ForeColor = System.Drawing.Color.White;
            this.buttonTemizle.Location = new System.Drawing.Point(6, 38);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(145, 65);
            this.buttonTemizle.TabIndex = 14;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // textBoxKitapTurKodu
            // 
            this.textBoxKitapTurKodu.BackColor = System.Drawing.Color.White;
            this.textBoxKitapTurKodu.Location = new System.Drawing.Point(251, 294);
            this.textBoxKitapTurKodu.Name = "textBoxKitapTurKodu";
            this.textBoxKitapTurKodu.Size = new System.Drawing.Size(246, 36);
            this.textBoxKitapTurKodu.TabIndex = 11;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.BackColor = System.Drawing.Color.White;
            this.textBoxISBN.Location = new System.Drawing.Point(251, 236);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(246, 36);
            this.textBoxISBN.TabIndex = 10;
            // 
            // textBoxYazarSoyad
            // 
            this.textBoxYazarSoyad.BackColor = System.Drawing.Color.White;
            this.textBoxYazarSoyad.Location = new System.Drawing.Point(251, 185);
            this.textBoxYazarSoyad.Name = "textBoxYazarSoyad";
            this.textBoxYazarSoyad.Size = new System.Drawing.Size(362, 36);
            this.textBoxYazarSoyad.TabIndex = 9;
            // 
            // textBoxYazarAdi
            // 
            this.textBoxYazarAdi.BackColor = System.Drawing.Color.White;
            this.textBoxYazarAdi.Location = new System.Drawing.Point(251, 129);
            this.textBoxYazarAdi.Name = "textBoxYazarAdi";
            this.textBoxYazarAdi.Size = new System.Drawing.Size(362, 36);
            this.textBoxYazarAdi.TabIndex = 8;
            // 
            // textBoxKitapAdi
            // 
            this.textBoxKitapAdi.BackColor = System.Drawing.Color.White;
            this.textBoxKitapAdi.Location = new System.Drawing.Point(251, 76);
            this.textBoxKitapAdi.Name = "textBoxKitapAdi";
            this.textBoxKitapAdi.Size = new System.Drawing.Size(362, 36);
            this.textBoxKitapAdi.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 33);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kitap Tür Kodu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "ISBN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yazar Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kitap Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazar Adı:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelID.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelID.Location = new System.Drawing.Point(255, 40);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(24, 33);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.buttonKitapOduncVer);
            this.groupBox2.Controls.Add(this.dateTimePickerOduncAlmaTarihi);
            this.groupBox2.Controls.Add(this.textBoxOduncAlan);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(978, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 480);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Ödünç Alma";
            // 
            // buttonKitapOduncVer
            // 
            this.buttonKitapOduncVer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonKitapOduncVer.BackgroundImage")));
            this.buttonKitapOduncVer.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonKitapOduncVer.ForeColor = System.Drawing.Color.White;
            this.buttonKitapOduncVer.Location = new System.Drawing.Point(116, 199);
            this.buttonKitapOduncVer.Name = "buttonKitapOduncVer";
            this.buttonKitapOduncVer.Size = new System.Drawing.Size(192, 57);
            this.buttonKitapOduncVer.TabIndex = 15;
            this.buttonKitapOduncVer.Text = "Kitabı Ödünç Ver";
            this.buttonKitapOduncVer.UseVisualStyleBackColor = true;
            this.buttonKitapOduncVer.Click += new System.EventHandler(this.buttonKitapOduncVer_Click);
            // 
            // dateTimePickerOduncAlmaTarihi
            // 
            this.dateTimePickerOduncAlmaTarihi.Location = new System.Drawing.Point(207, 119);
            this.dateTimePickerOduncAlmaTarihi.Name = "dateTimePickerOduncAlmaTarihi";
            this.dateTimePickerOduncAlmaTarihi.Size = new System.Drawing.Size(172, 29);
            this.dateTimePickerOduncAlmaTarihi.TabIndex = 9;
            // 
            // textBoxOduncAlan
            // 
            this.textBoxOduncAlan.Location = new System.Drawing.Point(207, 69);
            this.textBoxOduncAlan.Name = "textBoxOduncAlan";
            this.textBoxOduncAlan.Size = new System.Drawing.Size(172, 29);
            this.textBoxOduncAlan.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 33);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tarih:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 33);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ödünç Alan:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.buttonKitabiIadeEt);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.labelGecikmeBedeli);
            this.groupBox3.Controls.Add(this.buttonGecikmeBedeliHesapla);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(1411, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 480);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitap İade";
            // 
            // buttonKitabiIadeEt
            // 
            this.buttonKitabiIadeEt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonKitabiIadeEt.BackgroundImage")));
            this.buttonKitabiIadeEt.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonKitabiIadeEt.ForeColor = System.Drawing.Color.White;
            this.buttonKitabiIadeEt.Location = new System.Drawing.Point(99, 288);
            this.buttonKitabiIadeEt.Name = "buttonKitabiIadeEt";
            this.buttonKitabiIadeEt.Size = new System.Drawing.Size(192, 57);
            this.buttonKitabiIadeEt.TabIndex = 16;
            this.buttonKitabiIadeEt.Text = "Kitabı İade Et";
            this.buttonKitabiIadeEt.UseVisualStyleBackColor = true;
            this.buttonKitabiIadeEt.Click += new System.EventHandler(this.buttonKitabiIadeEt_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(301, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 28);
            this.label11.TabIndex = 15;
            this.label11.Text = "TL";
            // 
            // labelGecikmeBedeli
            // 
            this.labelGecikmeBedeli.AutoSize = true;
            this.labelGecikmeBedeli.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGecikmeBedeli.Location = new System.Drawing.Point(240, 66);
            this.labelGecikmeBedeli.Name = "labelGecikmeBedeli";
            this.labelGecikmeBedeli.Size = new System.Drawing.Size(31, 33);
            this.labelGecikmeBedeli.TabIndex = 14;
            this.labelGecikmeBedeli.Text = "0";
            // 
            // buttonGecikmeBedeliHesapla
            // 
            this.buttonGecikmeBedeliHesapla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGecikmeBedeliHesapla.BackgroundImage")));
            this.buttonGecikmeBedeliHesapla.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGecikmeBedeliHesapla.ForeColor = System.Drawing.Color.White;
            this.buttonGecikmeBedeliHesapla.Location = new System.Drawing.Point(99, 196);
            this.buttonGecikmeBedeliHesapla.Name = "buttonGecikmeBedeliHesapla";
            this.buttonGecikmeBedeliHesapla.Size = new System.Drawing.Size(192, 57);
            this.buttonGecikmeBedeliHesapla.TabIndex = 13;
            this.buttonGecikmeBedeliHesapla.Text = "Gecikme Bedeli Hesapla";
            this.buttonGecikmeBedeliHesapla.UseVisualStyleBackColor = true;
            this.buttonGecikmeBedeliHesapla.Click += new System.EventHandler(this.buttonGecikmeBedeliHesapla_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 33);
            this.label10.TabIndex = 5;
            this.label10.Text = "Gecikme Bedeli:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.dataGridViewKitaplar);
            this.groupBox4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(12, 498);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1769, 243);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kitap Listesi";
            // 
            // dataGridViewKitaplar
            // 
            this.dataGridViewKitaplar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKitaplar.ColumnHeadersHeight = 34;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(10, 32);
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.RowHeadersWidth = 62;
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(1776, 208);
            this.dataGridViewKitaplar.TabIndex = 0;
            this.dataGridViewKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKitaplar_CellClick);
            // 
            // FormKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1799, 700);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormKitaplar";
            this.Text = "BerNur Kütüphane Yönetim Sistemi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKitaplar_FormClosed);
            this.Load += new System.EventHandler(this.FormKitaplar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label labelID;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBoxKitapTurKodu;
        private TextBox textBoxISBN;
        private TextBox textBoxYazarSoyad;
        private TextBox textBoxYazarAdi;
        private TextBox textBoxKitapAdi;
        private GroupBox groupBox4;
        private Button buttonKitapEkle;
        private Button buttonKitapBilgiGuncelle;
        private DateTimePicker dateTimePickerOduncAlmaTarihi;
        private TextBox textBoxOduncAlan;
        private Label label9;
        private Label label8;
        private Label label11;
        private Label labelGecikmeBedeli;
        private Button buttonGecikmeBedeliHesapla;
        private Label label10;
        private Button buttonKitabiIadeEt;
        private Button buttonKitapOduncVer;
        private DataGridView dataGridViewKitaplar;
        private Button buttonTemizle;
        private Button buttonAra;
        private Button buttonTumKıtaplarıGoster;
        private Button buttonSil;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
    }
}