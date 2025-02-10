namespace iremorcinRestorantOtomasyon
{
    partial class siparisformu
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
            this.label5 = new System.Windows.Forms.Label();
            this.siparisListe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.siparisSiparisNo = new System.Windows.Forms.TextBox();
            this.siparisMasaNo = new System.Windows.Forms.TextBox();
            this.siparisGuncelle = new System.Windows.Forms.Button();
            this.siparisSil = new System.Windows.Forms.Button();
            this.siparisAra = new System.Windows.Forms.Button();
            this.siparisEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.siparisToplamTutar = new System.Windows.Forms.TextBox();
            this.siparisUrunAdeti = new System.Windows.Forms.TextBox();
            this.siparisUrunler = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.siparisSiparisTarihi = new System.Windows.Forms.DateTimePicker();
            this.siparisSiparisSaati = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.anlikTarihgosterge = new System.Windows.Forms.Label();
            this.anlikSaatgosterge = new System.Windows.Forms.Label();
            this.anlikSaatTarih = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(79, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.MinimumSize = new System.Drawing.Size(74, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "RATATUY";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siparisListe
            // 
            this.siparisListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.siparisListe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siparisListe.HideSelection = false;
            this.siparisListe.Location = new System.Drawing.Point(0, 172);
            this.siparisListe.Margin = new System.Windows.Forms.Padding(2);
            this.siparisListe.Name = "siparisListe";
            this.siparisListe.Size = new System.Drawing.Size(952, 200);
            this.siparisListe.TabIndex = 8;
            this.siparisListe.UseCompatibleStateImageBehavior = false;
            this.siparisListe.View = System.Windows.Forms.View.Details;
            this.siparisListe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.siparisListe_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sipariş No";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Masa No";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 130;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ürünler";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ürün Adedi";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Toplam Tutar";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 110;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Sipariş Saati";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Sipariş Tarihi";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 140;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 16;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 9, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.siparisSiparisNo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.siparisMasaNo, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.siparisGuncelle, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.siparisSil, 9, 5);
            this.tableLayoutPanel1.Controls.Add(this.siparisAra, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.siparisEkle, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 13, 1);
            this.tableLayoutPanel1.Controls.Add(this.siparisToplamTutar, 11, 1);
            this.tableLayoutPanel1.Controls.Add(this.siparisUrunAdeti, 11, 3);
            this.tableLayoutPanel1.Controls.Add(this.siparisUrunler, 15, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.siparisSiparisTarihi, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.siparisSiparisSaati, 7, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 48);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(952, 114);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sipariş No :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masa No :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(405, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Adetleri :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(200, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sipariş Saati :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siparisSiparisNo
            // 
            this.siparisSiparisNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siparisSiparisNo.Location = new System.Drawing.Point(104, 7);
            this.siparisSiparisNo.Margin = new System.Windows.Forms.Padding(2);
            this.siparisSiparisNo.Name = "siparisSiparisNo";
            this.siparisSiparisNo.Size = new System.Drawing.Size(86, 20);
            this.siparisSiparisNo.TabIndex = 4;
            this.siparisSiparisNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siparisMasaNo
            // 
            this.siparisMasaNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siparisMasaNo.Location = new System.Drawing.Point(104, 32);
            this.siparisMasaNo.Margin = new System.Windows.Forms.Padding(2);
            this.siparisMasaNo.Name = "siparisMasaNo";
            this.siparisMasaNo.Size = new System.Drawing.Size(86, 20);
            this.siparisMasaNo.TabIndex = 5;
            this.siparisMasaNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siparisGuncelle
            // 
            this.siparisGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siparisGuncelle.Location = new System.Drawing.Point(310, 65);
            this.siparisGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.siparisGuncelle.Name = "siparisGuncelle";
            this.siparisGuncelle.Size = new System.Drawing.Size(85, 29);
            this.siparisGuncelle.TabIndex = 10;
            this.siparisGuncelle.Text = "Güncelle";
            this.siparisGuncelle.UseVisualStyleBackColor = true;
            this.siparisGuncelle.Click += new System.EventHandler(this.siparisGuncelle_Click);
            // 
            // siparisSil
            // 
            this.siparisSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siparisSil.Location = new System.Drawing.Point(405, 65);
            this.siparisSil.Margin = new System.Windows.Forms.Padding(2);
            this.siparisSil.Name = "siparisSil";
            this.siparisSil.Size = new System.Drawing.Size(87, 29);
            this.siparisSil.TabIndex = 11;
            this.siparisSil.Text = "Sil";
            this.siparisSil.UseVisualStyleBackColor = true;
            this.siparisSil.Click += new System.EventHandler(this.siparisSil_Click);
            // 
            // siparisAra
            // 
            this.siparisAra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siparisAra.Location = new System.Drawing.Point(8, 65);
            this.siparisAra.Margin = new System.Windows.Forms.Padding(2);
            this.siparisAra.Name = "siparisAra";
            this.siparisAra.Size = new System.Drawing.Size(86, 29);
            this.siparisAra.TabIndex = 8;
            this.siparisAra.Text = "Ara";
            this.siparisAra.UseVisualStyleBackColor = true;
            this.siparisAra.Click += new System.EventHandler(this.siparisAra_Click);
            // 
            // siparisEkle
            // 
            this.siparisEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siparisEkle.Location = new System.Drawing.Point(200, 65);
            this.siparisEkle.Margin = new System.Windows.Forms.Padding(2);
            this.siparisEkle.Name = "siparisEkle";
            this.siparisEkle.Size = new System.Drawing.Size(100, 29);
            this.siparisEkle.TabIndex = 9;
            this.siparisEkle.Text = "Ekle";
            this.siparisEkle.UseVisualStyleBackColor = true;
            this.siparisEkle.Click += new System.EventHandler(this.siparisEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(405, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Toplam Tutar :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(584, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ürünler :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siparisToplamTutar
            // 
            this.siparisToplamTutar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siparisToplamTutar.Location = new System.Drawing.Point(502, 7);
            this.siparisToplamTutar.Margin = new System.Windows.Forms.Padding(2);
            this.siparisToplamTutar.Name = "siparisToplamTutar";
            this.siparisToplamTutar.Size = new System.Drawing.Size(72, 20);
            this.siparisToplamTutar.TabIndex = 14;
            this.siparisToplamTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siparisUrunAdeti
            // 
            this.siparisUrunAdeti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siparisUrunAdeti.Location = new System.Drawing.Point(502, 32);
            this.siparisUrunAdeti.Margin = new System.Windows.Forms.Padding(2);
            this.siparisUrunAdeti.Name = "siparisUrunAdeti";
            this.siparisUrunAdeti.Size = new System.Drawing.Size(72, 20);
            this.siparisUrunAdeti.TabIndex = 16;
            this.siparisUrunAdeti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siparisUrunler
            // 
            this.siparisUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siparisUrunler.Location = new System.Drawing.Point(680, 7);
            this.siparisUrunler.Margin = new System.Windows.Forms.Padding(2);
            this.siparisUrunler.Multiline = true;
            this.siparisUrunler.Name = "siparisUrunler";
            this.tableLayoutPanel1.SetRowSpan(this.siparisUrunler, 4);
            this.siparisUrunler.Size = new System.Drawing.Size(270, 54);
            this.siparisUrunler.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(201, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Sipariş Tarihi :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siparisSiparisTarihi
            // 
            this.siparisSiparisTarihi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siparisSiparisTarihi.Location = new System.Drawing.Point(311, 33);
            this.siparisSiparisTarihi.Name = "siparisSiparisTarihi";
            this.siparisSiparisTarihi.Size = new System.Drawing.Size(83, 20);
            this.siparisSiparisTarihi.TabIndex = 19;
            // 
            // siparisSiparisSaati
            // 
            this.siparisSiparisSaati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siparisSiparisSaati.Location = new System.Drawing.Point(311, 8);
            this.siparisSiparisSaati.Name = "siparisSiparisSaati";
            this.siparisSiparisSaati.Size = new System.Drawing.Size(83, 20);
            this.siparisSiparisSaati.TabIndex = 21;
            this.siparisSiparisSaati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::iremorcinRestorantOtomasyon.Properties.Resources.restoranticon;
            this.pictureBox1.Location = new System.Drawing.Point(24, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(39, 33);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(39, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // anlikTarihgosterge
            // 
            this.anlikTarihgosterge.AutoSize = true;
            this.anlikTarihgosterge.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.anlikTarihgosterge.ForeColor = System.Drawing.Color.White;
            this.anlikTarihgosterge.Location = new System.Drawing.Point(677, 9);
            this.anlikTarihgosterge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.anlikTarihgosterge.Name = "anlikTarihgosterge";
            this.anlikTarihgosterge.Size = new System.Drawing.Size(47, 16);
            this.anlikTarihgosterge.TabIndex = 24;
            this.anlikTarihgosterge.Text = "TARİH";
            this.anlikTarihgosterge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.anlikTarihgosterge_MouseClick);
            // 
            // anlikSaatgosterge
            // 
            this.anlikSaatgosterge.AutoSize = true;
            this.anlikSaatgosterge.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anlikSaatgosterge.ForeColor = System.Drawing.Color.White;
            this.anlikSaatgosterge.Location = new System.Drawing.Point(704, 27);
            this.anlikSaatgosterge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.anlikSaatgosterge.MinimumSize = new System.Drawing.Size(35, 15);
            this.anlikSaatgosterge.Name = "anlikSaatgosterge";
            this.anlikSaatgosterge.Size = new System.Drawing.Size(40, 16);
            this.anlikSaatgosterge.TabIndex = 23;
            this.anlikSaatgosterge.Text = "SAAT";
            this.anlikSaatgosterge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.anlikSaatgosterge_MouseClick);
            // 
            // anlikSaatTarih
            // 
            this.anlikSaatTarih.Tick += new System.EventHandler(this.anlikSaatTarih_Tick);
            // 
            // siparisformu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(952, 372);
            this.Controls.Add(this.anlikTarihgosterge);
            this.Controls.Add(this.anlikSaatgosterge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.siparisListe);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(968, 411);
            this.MinimumSize = new System.Drawing.Size(968, 411);
            this.Name = "siparisformu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Ekranı";
            this.Load += new System.EventHandler(this.siparisformu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView siparisListe;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox siparisSiparisNo;
        private System.Windows.Forms.TextBox siparisMasaNo;
        private System.Windows.Forms.Button siparisGuncelle;
        private System.Windows.Forms.Button siparisSil;
        private System.Windows.Forms.Button siparisAra;
        private System.Windows.Forms.Button siparisEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox siparisToplamTutar;
        private System.Windows.Forms.TextBox siparisUrunAdeti;
        private System.Windows.Forms.TextBox siparisUrunler;
        private System.Windows.Forms.Label anlikTarihgosterge;
        private System.Windows.Forms.Label anlikSaatgosterge;
        private System.Windows.Forms.Timer anlikSaatTarih;
        private System.Windows.Forms.DateTimePicker siparisSiparisTarihi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox siparisSiparisSaati;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}