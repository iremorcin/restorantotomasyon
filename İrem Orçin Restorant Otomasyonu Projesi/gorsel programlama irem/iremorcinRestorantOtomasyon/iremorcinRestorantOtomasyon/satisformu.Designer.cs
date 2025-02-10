namespace iremorcinRestorantOtomasyon
{
    partial class satisformu
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
            this.satisListe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.satisOdemeNo = new System.Windows.Forms.TextBox();
            this.satisMasaNo = new System.Windows.Forms.TextBox();
            this.satisGuncelle = new System.Windows.Forms.Button();
            this.satisSil = new System.Windows.Forms.Button();
            this.satisAra = new System.Windows.Forms.Button();
            this.satisEkle = new System.Windows.Forms.Button();
            this.satisToplamTutar = new System.Windows.Forms.TextBox();
            this.satisOdemeTuru = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.satisSiparisNo = new System.Windows.Forms.TextBox();
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
            this.label5.TabIndex = 15;
            this.label5.Text = "RATATUY";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // satisListe
            // 
            this.satisListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader10,
            this.columnHeader11});
            this.satisListe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.satisListe.HideSelection = false;
            this.satisListe.Location = new System.Drawing.Point(0, 166);
            this.satisListe.Margin = new System.Windows.Forms.Padding(2);
            this.satisListe.MinimumSize = new System.Drawing.Size(574, 200);
            this.satisListe.Name = "satisListe";
            this.satisListe.Size = new System.Drawing.Size(788, 200);
            this.satisListe.TabIndex = 13;
            this.satisListe.UseCompatibleStateImageBehavior = false;
            this.satisListe.View = System.Windows.Forms.View.Details;
            this.satisListe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.satisListe_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sipariş No";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ödeme No";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Masa No";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ödeme Türü";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Toplam Tutar";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 120;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 14;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 309F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 9, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.satisOdemeNo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.satisMasaNo, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.satisGuncelle, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.satisSil, 9, 5);
            this.tableLayoutPanel1.Controls.Add(this.satisAra, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.satisEkle, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.satisToplamTutar, 11, 3);
            this.tableLayoutPanel1.Controls.Add(this.satisOdemeTuru, 11, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.satisSiparisNo, 7, 1);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 110);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ödeme No :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(481, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Toplam Tutar :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(481, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ödeme Türü :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // satisOdemeNo
            // 
            this.satisOdemeNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.satisOdemeNo.Location = new System.Drawing.Point(104, 7);
            this.satisOdemeNo.Margin = new System.Windows.Forms.Padding(2);
            this.satisOdemeNo.Name = "satisOdemeNo";
            this.satisOdemeNo.Size = new System.Drawing.Size(119, 20);
            this.satisOdemeNo.TabIndex = 4;
            // 
            // satisMasaNo
            // 
            this.satisMasaNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.satisMasaNo.Location = new System.Drawing.Point(104, 32);
            this.satisMasaNo.Margin = new System.Windows.Forms.Padding(2);
            this.satisMasaNo.Name = "satisMasaNo";
            this.satisMasaNo.Size = new System.Drawing.Size(119, 20);
            this.satisMasaNo.TabIndex = 5;
            // 
            // satisGuncelle
            // 
            this.satisGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.satisGuncelle.Location = new System.Drawing.Point(355, 68);
            this.satisGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.satisGuncelle.Name = "satisGuncelle";
            this.satisGuncelle.Size = new System.Drawing.Size(116, 26);
            this.satisGuncelle.TabIndex = 10;
            this.satisGuncelle.Text = "Güncelle";
            this.satisGuncelle.UseVisualStyleBackColor = true;
            this.satisGuncelle.Click += new System.EventHandler(this.satisGuncelle_Click);
            // 
            // satisSil
            // 
            this.satisSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.satisSil.Location = new System.Drawing.Point(481, 68);
            this.satisSil.Margin = new System.Windows.Forms.Padding(2);
            this.satisSil.Name = "satisSil";
            this.satisSil.Size = new System.Drawing.Size(100, 26);
            this.satisSil.TabIndex = 11;
            this.satisSil.Text = "Sil";
            this.satisSil.UseVisualStyleBackColor = true;
            this.satisSil.Click += new System.EventHandler(this.satisSil_Click);
            // 
            // satisAra
            // 
            this.satisAra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.satisAra.Location = new System.Drawing.Point(8, 68);
            this.satisAra.Margin = new System.Windows.Forms.Padding(2);
            this.satisAra.Name = "satisAra";
            this.satisAra.Size = new System.Drawing.Size(86, 26);
            this.satisAra.TabIndex = 8;
            this.satisAra.Text = "Ara";
            this.satisAra.UseVisualStyleBackColor = true;
            this.satisAra.Click += new System.EventHandler(this.satisAra_Click);
            // 
            // satisEkle
            // 
            this.satisEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.satisEkle.Location = new System.Drawing.Point(233, 68);
            this.satisEkle.Margin = new System.Windows.Forms.Padding(2);
            this.satisEkle.Name = "satisEkle";
            this.satisEkle.Size = new System.Drawing.Size(112, 26);
            this.satisEkle.TabIndex = 9;
            this.satisEkle.Text = "Ekle";
            this.satisEkle.UseVisualStyleBackColor = true;
            this.satisEkle.Click += new System.EventHandler(this.satisEkle_Click);
            // 
            // satisToplamTutar
            // 
            this.satisToplamTutar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.satisToplamTutar.Location = new System.Drawing.Point(591, 32);
            this.satisToplamTutar.Margin = new System.Windows.Forms.Padding(2);
            this.satisToplamTutar.Name = "satisToplamTutar";
            this.satisToplamTutar.Size = new System.Drawing.Size(116, 20);
            this.satisToplamTutar.TabIndex = 14;
            // 
            // satisOdemeTuru
            // 
            this.satisOdemeTuru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.satisOdemeTuru.FormattingEnabled = true;
            this.satisOdemeTuru.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı"});
            this.satisOdemeTuru.Location = new System.Drawing.Point(591, 7);
            this.satisOdemeTuru.Margin = new System.Windows.Forms.Padding(2);
            this.satisOdemeTuru.Name = "satisOdemeTuru";
            this.satisOdemeTuru.Size = new System.Drawing.Size(116, 21);
            this.satisOdemeTuru.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(234, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sipariş No :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // satisSiparisNo
            // 
            this.satisSiparisNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.satisSiparisNo.Location = new System.Drawing.Point(356, 8);
            this.satisSiparisNo.Name = "satisSiparisNo";
            this.satisSiparisNo.Size = new System.Drawing.Size(114, 20);
            this.satisSiparisNo.TabIndex = 18;
            this.satisSiparisNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // anlikTarihgosterge
            // 
            this.anlikTarihgosterge.AutoSize = true;
            this.anlikTarihgosterge.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.anlikTarihgosterge.ForeColor = System.Drawing.Color.White;
            this.anlikTarihgosterge.Location = new System.Drawing.Point(615, 9);
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
            this.anlikSaatgosterge.Location = new System.Drawing.Point(641, 27);
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
            // satisformu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(788, 366);
            this.Controls.Add(this.anlikTarihgosterge);
            this.Controls.Add(this.anlikSaatgosterge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.satisListe);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(804, 405);
            this.MinimumSize = new System.Drawing.Size(804, 405);
            this.Name = "satisformu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Ekranı";
            this.Load += new System.EventHandler(this.satisformu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView satisListe;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox satisOdemeNo;
        private System.Windows.Forms.TextBox satisMasaNo;
        private System.Windows.Forms.Button satisGuncelle;
        private System.Windows.Forms.Button satisSil;
        private System.Windows.Forms.Button satisAra;
        private System.Windows.Forms.Button satisEkle;
        private System.Windows.Forms.TextBox satisToplamTutar;
        private System.Windows.Forms.ComboBox satisOdemeTuru;
        private System.Windows.Forms.Label anlikTarihgosterge;
        private System.Windows.Forms.Label anlikSaatgosterge;
        private System.Windows.Forms.Timer anlikSaatTarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox satisSiparisNo;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}