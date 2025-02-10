namespace iremorcinRestorantOtomasyon
{
    partial class menuformu
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
            this.menuListe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuUrunKodu = new System.Windows.Forms.TextBox();
            this.menuUrunAdi = new System.Windows.Forms.TextBox();
            this.menuGuncelle = new System.Windows.Forms.Button();
            this.menuSil = new System.Windows.Forms.Button();
            this.menuAra = new System.Windows.Forms.Button();
            this.menuEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.menuUrunFiyat = new System.Windows.Forms.TextBox();
            this.menuUrunKategori = new System.Windows.Forms.TextBox();
            this.menuUrunAciklama = new System.Windows.Forms.TextBox();
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
            this.label5.Location = new System.Drawing.Point(88, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.MinimumSize = new System.Drawing.Size(74, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "RATATUY";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuListe
            // 
            this.menuListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.menuListe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuListe.HideSelection = false;
            this.menuListe.Location = new System.Drawing.Point(0, 172);
            this.menuListe.Margin = new System.Windows.Forms.Padding(2);
            this.menuListe.MaximumSize = new System.Drawing.Size(668, 200);
            this.menuListe.MinimumSize = new System.Drawing.Size(632, 200);
            this.menuListe.Name = "menuListe";
            this.menuListe.Size = new System.Drawing.Size(656, 200);
            this.menuListe.TabIndex = 8;
            this.menuListe.UseCompatibleStateImageBehavior = false;
            this.menuListe.View = System.Windows.Forms.View.Details;
            this.menuListe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menuListe_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Kodu";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fiyat";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kategori";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Açıklama";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 180;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 12;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuUrunKodu, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuUrunAdi, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.menuGuncelle, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.menuSil, 9, 5);
            this.tableLayoutPanel1.Controls.Add(this.menuAra, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.menuEkle, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuUrunFiyat, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuUrunKategori, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.menuUrunAciklama, 11, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(654, 113);
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
            this.label1.Text = "Ürün Kodu :";
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
            this.label2.Text = "Ürün Adı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(200, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kategori :";
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
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuUrunKodu
            // 
            this.menuUrunKodu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuUrunKodu.Location = new System.Drawing.Point(104, 7);
            this.menuUrunKodu.Margin = new System.Windows.Forms.Padding(2);
            this.menuUrunKodu.Name = "menuUrunKodu";
            this.menuUrunKodu.Size = new System.Drawing.Size(86, 20);
            this.menuUrunKodu.TabIndex = 4;
            // 
            // menuUrunAdi
            // 
            this.menuUrunAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuUrunAdi.Location = new System.Drawing.Point(104, 32);
            this.menuUrunAdi.Margin = new System.Windows.Forms.Padding(2);
            this.menuUrunAdi.Name = "menuUrunAdi";
            this.menuUrunAdi.Size = new System.Drawing.Size(86, 20);
            this.menuUrunAdi.TabIndex = 5;
            // 
            // menuGuncelle
            // 
            this.menuGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuGuncelle.Location = new System.Drawing.Point(296, 68);
            this.menuGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.menuGuncelle.Name = "menuGuncelle";
            this.menuGuncelle.Size = new System.Drawing.Size(86, 26);
            this.menuGuncelle.TabIndex = 10;
            this.menuGuncelle.Text = "Güncelle";
            this.menuGuncelle.UseVisualStyleBackColor = true;
            this.menuGuncelle.Click += new System.EventHandler(this.menuGuncelle_Click);
            // 
            // menuSil
            // 
            this.menuSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuSil.Location = new System.Drawing.Point(392, 68);
            this.menuSil.Margin = new System.Windows.Forms.Padding(2);
            this.menuSil.Name = "menuSil";
            this.menuSil.Size = new System.Drawing.Size(76, 26);
            this.menuSil.TabIndex = 11;
            this.menuSil.Text = "Sil";
            this.menuSil.UseVisualStyleBackColor = true;
            this.menuSil.Click += new System.EventHandler(this.menuSil_Click);
            // 
            // menuAra
            // 
            this.menuAra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuAra.Location = new System.Drawing.Point(8, 68);
            this.menuAra.Margin = new System.Windows.Forms.Padding(2);
            this.menuAra.Name = "menuAra";
            this.menuAra.Size = new System.Drawing.Size(86, 26);
            this.menuAra.TabIndex = 8;
            this.menuAra.Text = "Ara";
            this.menuAra.UseVisualStyleBackColor = true;
            this.menuAra.Click += new System.EventHandler(this.menuAra_Click);
            // 
            // menuEkle
            // 
            this.menuEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuEkle.Location = new System.Drawing.Point(200, 68);
            this.menuEkle.Margin = new System.Windows.Forms.Padding(2);
            this.menuEkle.Name = "menuEkle";
            this.menuEkle.Size = new System.Drawing.Size(86, 26);
            this.menuEkle.TabIndex = 9;
            this.menuEkle.Text = "Ekle";
            this.menuEkle.UseVisualStyleBackColor = true;
            this.menuEkle.Click += new System.EventHandler(this.menuEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(392, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Açıklama :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuUrunFiyat
            // 
            this.menuUrunFiyat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuUrunFiyat.Location = new System.Drawing.Point(296, 7);
            this.menuUrunFiyat.Margin = new System.Windows.Forms.Padding(2);
            this.menuUrunFiyat.Name = "menuUrunFiyat";
            this.menuUrunFiyat.Size = new System.Drawing.Size(86, 20);
            this.menuUrunFiyat.TabIndex = 13;
            // 
            // menuUrunKategori
            // 
            this.menuUrunKategori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuUrunKategori.Location = new System.Drawing.Point(296, 32);
            this.menuUrunKategori.Margin = new System.Windows.Forms.Padding(2);
            this.menuUrunKategori.Name = "menuUrunKategori";
            this.menuUrunKategori.Size = new System.Drawing.Size(86, 20);
            this.menuUrunKategori.TabIndex = 14;
            // 
            // menuUrunAciklama
            // 
            this.menuUrunAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuUrunAciklama.Location = new System.Drawing.Point(474, 7);
            this.menuUrunAciklama.Margin = new System.Windows.Forms.Padding(2);
            this.menuUrunAciklama.Multiline = true;
            this.menuUrunAciklama.Name = "menuUrunAciklama";
            this.tableLayoutPanel1.SetRowSpan(this.menuUrunAciklama, 3);
            this.menuUrunAciklama.Size = new System.Drawing.Size(178, 46);
            this.menuUrunAciklama.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::iremorcinRestorantOtomasyon.Properties.Resources.restoranticon;
            this.pictureBox1.Location = new System.Drawing.Point(29, 11);
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
            this.anlikTarihgosterge.Location = new System.Drawing.Point(526, 11);
            this.anlikTarihgosterge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.anlikTarihgosterge.Name = "anlikTarihgosterge";
            this.anlikTarihgosterge.Size = new System.Drawing.Size(47, 16);
            this.anlikTarihgosterge.TabIndex = 26;
            this.anlikTarihgosterge.Text = "TARİH";
            // 
            // anlikSaatgosterge
            // 
            this.anlikSaatgosterge.AutoSize = true;
            this.anlikSaatgosterge.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anlikSaatgosterge.ForeColor = System.Drawing.Color.White;
            this.anlikSaatgosterge.Location = new System.Drawing.Point(554, 28);
            this.anlikSaatgosterge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.anlikSaatgosterge.MinimumSize = new System.Drawing.Size(35, 15);
            this.anlikSaatgosterge.Name = "anlikSaatgosterge";
            this.anlikSaatgosterge.Size = new System.Drawing.Size(40, 16);
            this.anlikSaatgosterge.TabIndex = 25;
            this.anlikSaatgosterge.Text = "SAAT";
            // 
            // anlikSaatTarih
            // 
            this.anlikSaatTarih.Tick += new System.EventHandler(this.anlikSaatTarih_Tick);
            // 
            // menuformu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(656, 372);
            this.Controls.Add(this.anlikTarihgosterge);
            this.Controls.Add(this.anlikSaatgosterge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuListe);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(672, 411);
            this.MinimumSize = new System.Drawing.Size(672, 411);
            this.Name = "menuformu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menü Ekranı";
            this.Load += new System.EventHandler(this.menuformu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView menuListe;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox menuUrunKodu;
        private System.Windows.Forms.TextBox menuUrunAdi;
        private System.Windows.Forms.Button menuGuncelle;
        private System.Windows.Forms.Button menuSil;
        private System.Windows.Forms.Button menuAra;
        private System.Windows.Forms.Button menuEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox menuUrunFiyat;
        private System.Windows.Forms.TextBox menuUrunKategori;
        private System.Windows.Forms.TextBox menuUrunAciklama;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label anlikTarihgosterge;
        private System.Windows.Forms.Label anlikSaatgosterge;
        private System.Windows.Forms.Timer anlikSaatTarih;
    }
}