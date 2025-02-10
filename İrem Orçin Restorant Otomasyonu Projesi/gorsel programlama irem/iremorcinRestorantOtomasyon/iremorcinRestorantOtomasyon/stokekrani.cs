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
    public partial class stokekrani : Form
    {
        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=RestorantOtomasyon;Integrated Security=True;");


        public stokekrani()
        {
            InitializeComponent();
        }

        private void stoklarAra()
        {
            stokListe.Items.Clear();
            stokListe.View = View.Details;
            stokListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand stokAra = new SqlCommand("select * from stokekrani where Urun_kodu = '" + stokUurunKodu.Text + "'", sqlBaglanti);
            SqlDataReader oku = stokAra.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["Urun_kodu"].ToString());
                item.SubItems.Add(oku["Urun_ismi"].ToString());
                item.SubItems.Add(oku["Mevcut_mik"].ToString());
                item.SubItems.Add(oku["Min_stok_mik"].ToString());
                item.SubItems.Add(oku["Tedarikci_bilgileri"].ToString());
                stokListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }
        private void stoklarListele()
        {
            stokListe.Items.Clear();
            stokListe.View = View.Details;
            stokListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand stokListele = new SqlCommand("select * from stokekrani", sqlBaglanti);
            SqlDataReader oku = stokListele.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["Urun_kodu"].ToString());
                item.SubItems.Add(oku["Urun_ismi"].ToString());
                item.SubItems.Add(oku["Mevcut_mik"].ToString());
                item.SubItems.Add(oku["Min_stok_mik"].ToString());
                item.SubItems.Add(oku["Tedarikci_bilgileri"].ToString());
                stokListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }
        private void stokTemizle()
        {
            stokUurunKodu.Text = "";
            stokUurunAdi.Text = "";
            stokMevcutMiktar.Text = "";
            stokMinStok.Text = "";
            stokTedarikciBilgileri.Text = "";
            stokUurunKodu.Focus();
        }



        private void anlikSaatTarih_Tick(object sender, EventArgs e)
        {
            anlikSaatgosterge.Text = DateTime.Now.ToLongTimeString();
            anlikTarihgosterge.Text = DateTime.Now.ToLongDateString();
        }
        private void stokekrani_Load(object sender, EventArgs e)
        {
            anlikSaatTarih.Start();
            stoklarListele();
        }
        private void stokAra_Click(object sender, EventArgs e)
        {
            stoklarAra();
        }
        private void stokEkle_Click(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            string stokEkle = "insert into stokekrani (Urun_kodu, Urun_ismi, Mevcut_mik, Min_stok_mik, Tedarikci_bilgileri) values (@p1,@p2,@p3,@p4,@p5)";
            SqlCommand ekle = new SqlCommand(stokEkle, sqlBaglanti);
            ekle.Parameters.AddWithValue("@p1", stokUurunKodu.Text);
            ekle.Parameters.AddWithValue("@p2", stokUurunAdi.Text);
            ekle.Parameters.AddWithValue("@p3", stokMevcutMiktar.Text);
            ekle.Parameters.AddWithValue("@p4", stokMinStok.Text);
            ekle.Parameters.AddWithValue("@p5", stokTedarikciBilgileri.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("Stok ekleme başarıyla gerçekleşmiştir.");
            sqlBaglanti.Close();
            stoklarListele();
            stokTemizle();
        }
        private void stokGuncelle_Click(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            SqlCommand stokGuncelle = new SqlCommand("UPDATE stokekrani SET Urun_ismi = '" + stokUurunAdi.Text +
                "', Mevcut_mik = '" + stokMevcutMiktar.Text + "', Min_stok_mik= '" + stokMinStok.Text +
                "', Tedarikci_bilgileri = '" + stokTedarikciBilgileri.Text + 
                "' WHERE Urun_kodu = '" + stokUurunKodu.Text + "'", sqlBaglanti);
            stokGuncelle.ExecuteNonQuery();
            MessageBox.Show("Stok düzenleme başarıyla gerçekleşmiştir.");
            sqlBaglanti.Close();
            stoklarListele();
            stokTemizle();
        }
        private void stokSil_Click(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            SqlCommand stokSil = new SqlCommand("Delete FROM stokekrani WHERE Urun_kodu = '" + stokUurunKodu.Text + "'", sqlBaglanti);
            stokSil.ExecuteNonQuery();
            MessageBox.Show("Stok kaydı başarıyla silinmiştir.");
            sqlBaglanti.Close();
            stoklarListele();
            stokTemizle();
        }
        private void stokListe_MouseClick(object sender, MouseEventArgs e)
        {
            stokUurunKodu.Text = stokListe.SelectedItems[0].SubItems[0].Text;
            stokUurunAdi.Text = stokListe.SelectedItems[0].SubItems[1].Text;
            stokMevcutMiktar.Text = stokListe.SelectedItems[0].SubItems[2].Text;
            stokMinStok.Text = stokListe.SelectedItems[0].SubItems[3].Text;
            stokTedarikciBilgileri.Text = stokListe.SelectedItems[0].SubItems[4].Text;
        }
    }
}
