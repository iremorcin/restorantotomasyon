namespace iremorcinRestorantOtomasyon
{
    partial class zraporformu
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
            this.anlikSaatgosterge = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.zraporListe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zraporRaporNo = new System.Windows.Forms.TextBox();
            this.zraporGuncelle = new System.Windows.Forms.Button();
            this.zraporSil = new System.Windows.Forms.Button();
            this.zraporAra = new System.Windows.Forms.Button();
            this.zraporEkle = new System.Windows.Forms.Button();
            this.zraporislemSayisi = new System.Windows.Forms.TextBox();
            this.zraporToplamSatis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.zraporOdemeNo = new System.Windows.Forms.TextBox();
            this.zraporRaporTarihi = new System.Windows.Forms.DateTimePicker();
            this.anlikTarihgosterge = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.anlikTarihSaatzrapor = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // anlikSaatgosterge
            // 
            this.anlikSaatgosterge.AutoSize = true;
            this.anlikSaatgosterge.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anlikSaatgosterge.ForeColor = System.Drawing.Color.White;
            this.anlikSaatgosterge.Location = new System.Drawing.Point(513, 30);
            this.anlikSaatgosterge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.anlikSaatgosterge.MinimumSize = new System.Drawing.Size(35, 15);
            this.anlikSaatgosterge.Name = "anlikSaatgosterge";
            this.anlikSaatgosterge.Size = new System.Drawing.Size(40, 16);
            this.anlikSaatgosterge.TabIndex = 21;
            this.anlikSaatgosterge.Text = "SAAT";
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
            // zraporListe
            // 
            this.zraporListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.zraporListe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.zraporListe.HideSelection = false;
            this.zraporListe.Location = new System.Drawing.Point(0, 166);
            this.zraporListe.Margin = new System.Windows.Forms.Padding(2);
            this.zraporListe.MinimumSize = new System.Drawing.Size(601, 200);
            this.zraporListe.Name = "zraporListe";
            this.zraporListe.Size = new System.Drawing.Size(685, 200);
            this.zraporListe.TabIndex = 18;
            this.zraporListe.UseCompatibleStateImageBehavior = false;
            this.zraporListe.View = System.Windows.Forms.View.Details;
            this.zraporListe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.zraporListe_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Rapor No";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ödeme Noları";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Rapor Tarihi";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Toplam Satış";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "İşlem Sayısı";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 120;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 12;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 9, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.zraporRaporNo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.zraporGuncelle, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.zraporSil, 9, 5);
            this.tableLayoutPanel1.Controls.Add(this.zraporAra, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.zraporEkle, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.zraporislemSayisi, 11, 3);
            this.tableLayoutPanel1.Controls.Add(this.zraporToplamSatis, 11, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.zraporOdemeNo, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.zraporRaporTarihi, 7, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 51);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(685, 110);
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
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rapor No :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(207, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rapor Tarihi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(429, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "İşlem Sayısı :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(429, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toplam Satış :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zraporRaporNo
            // 
            this.zraporRaporNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zraporRaporNo.Location = new System.Drawing.Point(104, 7);
            this.zraporRaporNo.Margin = new System.Windows.Forms.Padding(2);
            this.zraporRaporNo.Name = "zraporRaporNo";
            this.zraporRaporNo.Size = new System.Drawing.Size(93, 20);
            this.zraporRaporNo.TabIndex = 4;
            // 
            // zraporGuncelle
            // 
            this.zraporGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zraporGuncelle.Location = new System.Drawing.Point(313, 68);
            this.zraporGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.zraporGuncelle.Name = "zraporGuncelle";
            this.zraporGuncelle.Size = new System.Drawing.Size(106, 26);
            this.zraporGuncelle.TabIndex = 10;
            this.zraporGuncelle.Text = "Güncelle";
            this.zraporGuncelle.UseVisualStyleBackColor = true;
            this.zraporGuncelle.Click += new System.EventHandler(this.zraporGuncelle_Click);
            // 
            // zraporSil
            // 
            this.zraporSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zraporSil.Location = new System.Drawing.Point(429, 68);
            this.zraporSil.Margin = new System.Windows.Forms.Padding(2);
            this.zraporSil.Name = "zraporSil";
            this.zraporSil.Size = new System.Drawing.Size(119, 26);
            this.zraporSil.TabIndex = 11;
            this.zraporSil.Text = "Sil";
            this.zraporSil.UseVisualStyleBackColor = true;
            this.zraporSil.Click += new System.EventHandler(this.zraporSil_Click);
            // 
            // zraporAra
            // 
            this.zraporAra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zraporAra.Location = new System.Drawing.Point(8, 68);
            this.zraporAra.Margin = new System.Windows.Forms.Padding(2);
            this.zraporAra.Name = "zraporAra";
            this.zraporAra.Size = new System.Drawing.Size(86, 26);
            this.zraporAra.TabIndex = 8;
            this.zraporAra.Text = "Ara";
            this.zraporAra.UseVisualStyleBackColor = true;
            this.zraporAra.Click += new System.EventHandler(this.zraporAra_Click);
            // 
            // zraporEkle
            // 
            this.zraporEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zraporEkle.Location = new System.Drawing.Point(207, 68);
            this.zraporEkle.Margin = new System.Windows.Forms.Padding(2);
            this.zraporEkle.Name = "zraporEkle";
            this.zraporEkle.Size = new System.Drawing.Size(96, 26);
            this.zraporEkle.TabIndex = 9;
            this.zraporEkle.Text = "Ekle";
            this.zraporEkle.UseVisualStyleBackColor = true;
            this.zraporEkle.Click += new System.EventHandler(this.zraporEkle_Click);
            // 
            // zraporislemSayisi
            // 
            this.zraporislemSayisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zraporislemSayisi.Location = new System.Drawing.Point(554, 31);
            this.zraporislemSayisi.Margin = new System.Windows.Forms.Padding(2);
            this.zraporislemSayisi.Name = "zraporislemSayisi";
            this.zraporislemSayisi.Size = new System.Drawing.Size(129, 20);
            this.zraporislemSayisi.TabIndex = 14;
            // 
            // zraporToplamSatis
            // 
            this.zraporToplamSatis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zraporToplamSatis.Location = new System.Drawing.Point(554, 7);
            this.zraporToplamSatis.Margin = new System.Windows.Forms.Padding(2);
            this.zraporToplamSatis.Name = "zraporToplamSatis";
            this.zraporToplamSatis.Size = new System.Drawing.Size(129, 20);
            this.zraporToplamSatis.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(208, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Odeme No :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zraporOdemeNo
            // 
            this.zraporOdemeNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zraporOdemeNo.Location = new System.Drawing.Point(314, 8);
            this.zraporOdemeNo.Name = "zraporOdemeNo";
            this.zraporOdemeNo.Size = new System.Drawing.Size(104, 20);
            this.zraporOdemeNo.TabIndex = 17;
            this.zraporOdemeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zraporRaporTarihi
            // 
            this.zraporRaporTarihi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zraporRaporTarihi.Location = new System.Drawing.Point(314, 32);
            this.zraporRaporTarihi.Name = "zraporRaporTarihi";
            this.zraporRaporTarihi.Size = new System.Drawing.Size(104, 20);
            this.zraporRaporTarihi.TabIndex = 18;
            // 
            // anlikTarihgosterge
            // 
            this.anlikTarihgosterge.AutoSize = true;
            this.anlikTarihgosterge.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.anlikTarihgosterge.ForeColor = System.Drawing.Color.White;
            this.anlikTarihgosterge.Location = new System.Drawing.Point(486, 12);
            this.anlikTarihgosterge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.anlikTarihgosterge.MinimumSize = new System.Drawing.Size(47, 16);
            this.anlikTarihgosterge.Name = "anlikTarihgosterge";
            this.anlikTarihgosterge.Size = new System.Drawing.Size(47, 16);
            this.anlikTarihgosterge.TabIndex = 22;
            this.anlikTarihgosterge.Text = "TARİH";
            this.anlikTarihgosterge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.anlikTarihgosterge_MouseClick);
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
            // anlikTarihSaatzrapor
            // 
            this.anlikTarihSaatzrapor.Tick += new System.EventHandler(this.anlikTarihSaatzrapor_Tick);
            // 
            // zraporformu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(685, 366);
            this.Controls.Add(this.anlikTarihgosterge);
            this.Controls.Add(this.anlikSaatgosterge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.zraporListe);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(701, 405);
            this.MinimumSize = new System.Drawing.Size(701, 405);
            this.Name = "zraporformu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "zraporformu";
            this.Load += new System.EventHandler(this.zraporformu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label anlikSaatgosterge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView zraporListe;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox zraporRaporNo;
        private System.Windows.Forms.Button zraporGuncelle;
        private System.Windows.Forms.Button zraporSil;
        private System.Windows.Forms.Button zraporAra;
        private System.Windows.Forms.Button zraporEkle;
        private System.Windows.Forms.TextBox zraporislemSayisi;
        private System.Windows.Forms.TextBox zraporToplamSatis;
        private System.Windows.Forms.Label anlikTarihgosterge;
        private System.Windows.Forms.Timer anlikTarihSaatzrapor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox zraporOdemeNo;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.DateTimePicker zraporRaporTarihi;
    }
}