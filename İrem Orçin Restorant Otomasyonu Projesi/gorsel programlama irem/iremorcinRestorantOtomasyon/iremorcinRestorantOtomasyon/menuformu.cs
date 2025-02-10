using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iremorcinRestorantOtomasyon
{
    public partial class menuformu : Form
    {
        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=RestorantOtomasyon;Integrated Security=True;");

        public menuformu()
        {
            InitializeComponent();
        }

        private void menulerAra()
        {
            menuListe.Items.Clear();
            menuListe.View = View.Details;
            menuListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand menuAra = new SqlCommand("SELECT * FROM menuform WHERE Urun_kodu = '" + menuUrunKodu.Text + "'", sqlBaglanti);
            SqlDataReader oku = menuAra.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["Urun_kodu"].ToString());
                item.SubItems.Add(oku["isim"].ToString());
                item.SubItems.Add(oku["fiyat"].ToString());
                item.SubItems.Add(oku["kategori"].ToString());
                item.SubItems.Add(oku["aciklama"].ToString());
                menuListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }
        private void menulerListele()
        {
            menuListe.Items.Clear();
            menuListe.View = View.Details;
            menuListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand menuListele = new SqlCommand("SELECT * FROM menuform", sqlBaglanti);
            SqlDataReader oku = menuListele.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["Urun_kodu"].ToString());
                item.SubItems.Add(oku["isim"].ToString());
                item.SubItems.Add(oku["fiyat"].ToString());
                item.SubItems.Add(oku["kategori"].ToString());
                item.SubItems.Add(oku["aciklama"].ToString());
                menuListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }
        private void menuTemizle()
        {
            menuUrunKodu.Text = "";
            menuUrunAdi.Text = "";
            menuUrunFiyat.Text = "";
            menuUrunKategori.Text = "";
            menuUrunAciklama.Text = "";
            menuUrunKodu.Focus();
        }





        private void anlikSaatTarih_Tick(object sender, EventArgs e)
        {
            anlikSaatgosterge.Text = DateTime.Now.ToLongTimeString();
            anlikTarihgosterge.Text = DateTime.Now.ToLongDateString();
        }

        private void menuformu_Load(object sender, EventArgs e)
        {
            anlikSaatTarih.Start();
            menulerListele();
        }

        private void menuAra_Click(object sender, EventArgs e)
        {
            menulerAra();
        }

        private void menuEkle_Click(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            string menuEkle = "insert into menuform (Urun_kodu, isim, fiyat, kategori, aciklama) values (@p1,@p2,@p3,@p4,@p5)";
            SqlCommand ekle = new SqlCommand(menuEkle, sqlBaglanti);
            ekle.Parameters.AddWithValue("@p1", menuUrunKodu.Text);
            ekle.Parameters.AddWithValue("@p2", menuUrunAdi.Text);
            ekle.Parameters.AddWithValue("@p3", menuUrunFiyat.Text);
            ekle.Parameters.AddWithValue("@p4", menuUrunKategori.Text);
            ekle.Parameters.AddWithValue("@p5", menuUrunAciklama.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("Ürün kaydı başarıyla gerçekleşmiştir.");
            sqlBaglanti.Close();
            menulerListele();
            menuTemizle();
        }

        private void menuGuncelle_Click(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            SqlCommand menuGuncelle = new SqlCommand("UPDATE menuform SET isim= '" + menuUrunAdi.Text + "',  fiyat = '"
            + menuUrunFiyat.Text + "', kategori = '" + menuUrunKategori.Text + "', aciklama = '"+ menuUrunAciklama.Text + "' WHERE Urun_kodu = '" + menuUrunKodu.Text + "'", sqlBaglanti);
            menuGuncelle.ExecuteNonQuery();
            MessageBox.Show("Menü güncelleme başarıyla gerçekleşmiştir.");
            sqlBaglanti.Close();
            menulerListele();
            menuTemizle();
        }

        private void menuSil_Click(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            SqlCommand menuSil = new SqlCommand("Delete FROM menuform WHERE Urun_kodu = '" + menuUrunKodu.Text + "'", sqlBaglanti);
            menuSil.ExecuteNonQuery();
            MessageBox.Show("Ürün kaydı başarıyla silinmiştir.");
            sqlBaglanti.Close();
            menulerListele();
            menuTemizle();
        }

        private void menuListe_MouseClick(object sender, MouseEventArgs e)
        {
            menuUrunKodu.Text = menuListe.SelectedItems[0].SubItems[0].Text;
            menuUrunAdi.Text = menuListe.SelectedItems[0].SubItems[1].Text;
            menuUrunFiyat.Text = menuListe.SelectedItems[0].SubItems[2].Text;
            menuUrunKategori.Text = menuListe.SelectedItems[0].SubItems[3].Text;
            menuUrunAciklama.Text = menuListe.SelectedItems[0].SubItems[4].Text;
        }
    }
}
