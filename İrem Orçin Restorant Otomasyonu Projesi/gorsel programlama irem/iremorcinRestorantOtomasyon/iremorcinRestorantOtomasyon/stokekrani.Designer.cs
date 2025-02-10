namespace iremorcinRestorantOtomasyon
{
    partial class stokekrani
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
            this.stokListe = new System.Windows.Forms.ListView();
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
            this.stokUurunKodu = new System.Windows.Forms.TextBox();
            this.stokUurunAdi = new System.Windows.Forms.TextBox();
            this.stokGuncelle = new System.Windows.Forms.Button();
            this.stokSil = new System.Windows.Forms.Button();
            this.stokAra = new System.Windows.Forms.Button();
            this.stokEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.stokMevcutMiktar = new System.Windows.Forms.TextBox();
            this.stokMinStok = new System.Windows.Forms.TextBox();
            this.stokTedarikciBilgileri = new System.Windows.Forms.TextBox();
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
            this.label5.Location = new System.Drawing.Point(82, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.MinimumSize = new System.Drawing.Size(74, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "RATATUY";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stokListe
            // 
            this.stokListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.stokListe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stokListe.HideSelection = false;
            this.stokListe.Location = new System.Drawing.Point(0, 166);
            this.stokListe.Margin = new System.Windows.Forms.Padding(2);
            this.stokListe.MinimumSize = new System.Drawing.Size(632, 200);
            this.stokListe.Name = "stokListe";
            this.stokListe.Size = new System.Drawing.Size(759, 200);
            this.stokListe.TabIndex = 18;
            this.stokListe.UseCompatibleStateImageBehavior = false;
            this.stokListe.View = System.Windows.Forms.View.Details;
            this.stokListe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stokListe_MouseClick);
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
            this.columnHeader3.Text = "Mevcut Miktar";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Min. Stok";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tedarikçi Bilgileri";
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.stokUurunKodu, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.stokUurunAdi, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.stokGuncelle, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.stokSil, 9, 5);
            this.tableLayoutPanel1.Controls.Add(this.stokAra, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.stokEkle, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.stokMevcutMiktar, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.stokMinStok, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.stokTedarikciBilgileri, 11, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 51);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(759, 110);
            this.tableLayoutPanel1.TabIndex = 17;
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
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Min. Stok :";
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
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mevcut Miktar :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stokUurunKodu
            // 
            this.stokUurunKodu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stokUurunKodu.Location = new System.Drawing.Point(104, 7);
            this.stokUurunKodu.Margin = new System.Windows.Forms.Padding(2);
            this.stokUurunKodu.Name = "stokUurunKodu";
            this.stokUurunKodu.Size = new System.Drawing.Size(86, 20);
            this.stokUurunKodu.TabIndex = 4;
            // 
            // stokUurunAdi
            // 
            this.stokUurunAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stokUurunAdi.Location = new System.Drawing.Point(104, 32);
            this.stokUurunAdi.Margin = new System.Windows.Forms.Padding(2);
            this.stokUurunAdi.Name = "stokUurunAdi";
            this.stokUurunAdi.Size = new System.Drawing.Size(86, 20);
            this.stokUurunAdi.TabIndex = 5;
            // 
            // stokGuncelle
            // 
            this.stokGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stokGuncelle.Location = new System.Drawing.Point(305, 68);
            this.stokGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.stokGuncelle.Name = "stokGuncelle";
            this.stokGuncelle.Size = new System.Drawing.Size(91, 26);
            this.stokGuncelle.TabIndex = 10;
            this.stokGuncelle.Text = "Güncelle";
            this.stokGuncelle.UseVisualStyleBackColor = true;
            this.stokGuncelle.Click += new System.EventHandler(this.stokGuncelle_Click);
            // 
            // stokSil
            // 
            this.stokSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stokSil.Location = new System.Drawing.Point(406, 68);
            this.stokSil.Margin = new System.Windows.Forms.Padding(2);
            this.stokSil.Name = "stokSil";
            this.stokSil.Size = new System.Drawing.Size(77, 26);
            this.stokSil.TabIndex = 11;
            this.stokSil.Text = "Sil";
            this.stokSil.UseVisualStyleBackColor = true;
            this.stokSil.Click += new System.EventHandler(this.stokSil_Click);
            // 
            // stokAra
            // 
            this.stokAra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stokAra.Location = new System.Drawing.Point(8, 68);
            this.stokAra.Margin = new System.Windows.Forms.Padding(2);
            this.stokAra.Name = "stokAra";
            this.stokAra.Size = new System.Drawing.Size(86, 26);
            this.stokAra.TabIndex = 8;
            this.stokAra.Text = "Ara";
            this.stokAra.UseVisualStyleBackColor = true;
            this.stokAra.Click += new System.EventHandler(this.stokAra_Click);
            // 
            // stokEkle
            // 
            this.stokEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stokEkle.Location = new System.Drawing.Point(200, 68);
            this.stokEkle.Margin = new System.Windows.Forms.Padding(2);
            this.stokEkle.Name = "stokEkle";
            this.stokEkle.Size = new System.Drawing.Size(95, 26);
            this.stokEkle.TabIndex = 9;
            this.stokEkle.Text = "Ekle";
            this.stokEkle.UseVisualStyleBackColor = true;
            this.stokEkle.Click += new System.EventHandler(this.stokEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(406, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.tableLayoutPanel1.SetRowSpan(this.label6, 3);
            this.label6.Size = new System.Drawing.Size(77, 50);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tedarikçi Bilgileri :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stokMevcutMiktar
            // 
            this.stokMevcutMiktar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stokMevcutMiktar.Location = new System.Drawing.Point(305, 7);
            this.stokMevcutMiktar.Margin = new System.Windows.Forms.Padding(2);
            this.stokMevcutMiktar.Name = "stokMevcutMiktar";
            this.stokMevcutMiktar.Size = new System.Drawing.Size(91, 20);
            this.stokMevcutMiktar.TabIndex = 13;
            // 
            // stokMinStok
            // 
            this.stokMinStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stokMinStok.Location = new System.Drawing.Point(305, 32);
            this.stokMinStok.Margin = new System.Windows.Forms.Padding(2);
            this.stokMinStok.Name = "stokMinStok";
            this.stokMinStok.Size = new System.Drawing.Size(91, 20);
            this.stokMinStok.TabIndex = 14;
            // 
            // stokTedarikciBilgileri
            // 
            this.stokTedarikciBilgileri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stokTedarikciBilgileri.Location = new System.Drawing.Point(489, 7);
            this.stokTedarikciBilgileri.Margin = new System.Windows.Forms.Padding(2);
            this.stokTedarikciBilgileri.Multiline = true;
            this.stokTedarikciBilgileri.Name = "stokTedarikciBilgileri";
            this.tableLayoutPanel1.SetRowSpan(this.stokTedarikciBilgileri, 3);
            this.stokTedarikciBilgileri.Size = new System.Drawing.Size(268, 46);
            this.stokTedarikciBilgileri.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::iremorcinRestorantOtomasyon.Properties.Resources.restoranticon;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(39, 33);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(39, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // anlikTarihgosterge
            // 
            this.anlikTarihgosterge.AutoSize = true;
            this.anlikTarihgosterge.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.anlikTarihgosterge.ForeColor = System.Drawing.Color.White;
            this.anlikTarihgosterge.Location = new System.Drawing.Point(553, 9);
            this.anlikTarihgosterge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.anlikTarihgosterge.Name = "anlikTarihgosterge";
            this.anlikTarihgosterge.Size = new System.Drawing.Size(47, 16);
            this.anlikTarihgosterge.TabIndex = 24;
            this.anlikTarihgosterge.Text = "TARİH";
            // 
            // anlikSaatgosterge
            // 
            this.anlikSaatgosterge.AutoSize = true;
            this.anlikSaatgosterge.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anlikSaatgosterge.ForeColor = System.Drawing.Color.White;
            this.anlikSaatgosterge.Location = new System.Drawing.Point(580, 27);
            this.anlikSaatgosterge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.anlikSaatgosterge.MinimumSize = new System.Drawing.Size(35, 15);
            this.anlikSaatgosterge.Name = "anlikSaatgosterge";
            this.anlikSaatgosterge.Size = new System.Drawing.Size(40, 16);
            this.anlikSaatgosterge.TabIndex = 23;
            this.anlikSaatgosterge.Text = "SAAT";
            // 
            // anlikSaatTarih
            // 
            this.anlikSaatTarih.Tick += new System.EventHandler(this.anlikSaatTarih_Tick);
            // 
            // stokekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(759, 366);
            this.Controls.Add(this.anlikTarihgosterge);
            this.Controls.Add(this.anlikSaatgosterge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stokListe);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(775, 405);
            this.MinimumSize = new System.Drawing.Size(775, 405);
            this.Name = "stokekrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Ekranı";
            this.Load += new System.EventHandler(this.stokekrani_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView stokListe;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stokUurunKodu;
        private System.Windows.Forms.TextBox stokUurunAdi;
        private System.Windows.Forms.Button stokGuncelle;
        private System.Windows.Forms.Button stokSil;
        private System.Windows.Forms.Button stokAra;
        private System.Windows.Forms.Button stokEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stokMevcutMiktar;
        private System.Windows.Forms.TextBox stokMinStok;
        private System.Windows.Forms.TextBox stokTedarikciBilgileri;
        private System.Windows.Forms.Label anlikTarihgosterge;
        private System.Windows.Forms.Label anlikSaatgosterge;
        private System.Windows.Forms.Timer anlikSaatTarih;
    }
}