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
    public partial class siparisformu : Form
    {
        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=RestorantOtomasyon;Integrated Security=True;");


        public siparisformu()
        {
            InitializeComponent();
        }

        private void siparisleriAra()
        {
            siparisListe.Items.Clear();
            siparisListe.View = View.Details;
            siparisListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand siparisAra = new SqlCommand("select * from siparisformu where Siparis_No = '" + siparisSiparisNo.Text +"'", sqlBaglanti);
            SqlDataReader oku = siparisAra.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["Siparis_No"].ToString());
                item.SubItems.Add(oku["Masa_No"].ToString());
                item.SubItems.Add(oku["Urunler"].ToString());
                item.SubItems.Add(oku["Urun_Adetleri"].ToString());
                item.SubItems.Add(oku["Toplam_Tutar"].ToString());
                item.SubItems.Add(oku["Siparis_Saati"].ToString());
                item.SubItems.Add(oku["Siparis_Tarihi"].ToString());
                siparisListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }
        private void siparisListele()
        {
            siparisListe.Items.Clear();
            siparisListe.View = View.Details;
            siparisListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand sipraisListele = new SqlCommand("select * from siparisformu", sqlBaglanti);
            SqlDataReader oku = sipraisListele.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["Siparis_No"].ToString());
                item.SubItems.Add(oku["Masa_No"].ToString());
                item.SubItems.Add(oku["Urunler"].ToString());
                item.SubItems.Add(oku["Urun_Adetleri"].ToString());
                item.SubItems.Add(oku["Toplam_Tutar"].ToString());
                item.SubItems.Add(oku["Siparis_Saati"].ToString());
                item.SubItems.Add(oku["Siparis_Tarihi"].ToString());
                siparisListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }
        private void siparisTemizle()
        {
            siparisSiparisTarihi.Text = "";
            siparisMasaNo.Text = "";
            siparisSiparisNo.Text = "";
            siparisToplamTutar.Text = "";
            siparisUrunAdeti.Text = "";
            siparisUrunler.Text = "";
            siparisSiparisNo.Focus();
        }



        private void anlikSaatTarih_Tick(object sender, EventArgs e)
        {
            anlikSaatgosterge.Text = DateTime.Now.ToLongTimeString();
            anlikTarihgosterge.Text = DateTime.Now.ToLongDateString();
        }

        private void siparisformu_Load(object sender, EventArgs e)
        {
            anlikSaatTarih.Start();
            siparisListele();
        }

        private void siparisAra_Click(object sender, EventArgs e)
        {
            siparisleriAra();
        }

        private void siparisEkle_Click(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            string siparisEkle = "insert into siparisformu (Siparis_No, Masa_no, Urunler , Urun_Adetleri,Toplam_Tutar, Siparis_Saati, Siparis_Tarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
            SqlCommand ekle = new SqlCommand(siparisEkle, sqlBaglanti);
            ekle.Parameters.AddWithValue("@p1", siparisSiparisNo.Text);
            ekle.Parameters.AddWithValue("@p2", siparisMasaNo.Text);
            ekle.Parameters.AddWithValue("@p3", siparisUrunler.Text);
            ekle.Parameters.AddWithValue("@p4", siparisUrunAdeti.Text);
            ekle.Parameters.AddWithValue("@p5", siparisToplamTutar.Text);
            ekle.Parameters.AddWithValue("@p6", siparisSiparisSaati.Text);
            ekle.Parameters.AddWithValue("@p7", siparisSiparisTarihi.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("Sipariş başarıyla gerçekleşmiştir.");
            sqlBaglanti.Close();
            siparisListele();
            siparisTemizle();
        }

        private void siparisGuncelle_Click(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            SqlCommand siparisGuncelle = new SqlCommand("UPDATE siparisformu SET Masa_No = '" + siparisMasaNo.Text +
                "', Urunler = '" + siparisUrunler.Text + "', Urun_Adetleri = '" 
                + siparisUrunAdeti.Text + "', Toplam_Tutar = '" + siparisToplamTutar.Text +
                "', Siparis_Saati = '" + siparisSiparisSaati.Text + "', Siparis_Tarihi = '" + siparisSiparisTarihi.Text +
                "' WHERE Siparis_No = '" + siparisSiparisNo.Text + "'", sqlBaglanti);
            siparisGuncelle.ExecuteNonQuery();
            MessageBox.Show("Sipariş düzenleme başarıyla gerçekleşmiştir.");
            sqlBaglanti.Close();
            siparisListele();
            siparisTemizle();
        }

        private void siparisSil_Click(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            SqlCommand siparisSil = new SqlCommand("Delete FROM siparisformu WHERE Siparis_No = '" + siparisSiparisNo.Text + "'", sqlBaglanti);
            siparisSil.ExecuteNonQuery();
            MessageBox.Show("Sipariş kaydı başarıyla silinmiştir.");
            sqlBaglanti.Close();
            siparisListele();
            siparisTemizle();
        }

        private void siparisListe_MouseClick(object sender, MouseEventArgs e)
        {
            siparisSiparisNo.Text = siparisListe.SelectedItems[0].SubItems[0].Text;
            siparisMasaNo.Text = siparisListe.SelectedItems[0].SubItems[1].Text;
            siparisUrunler.Text = siparisListe.SelectedItems[0].SubItems[2].Text;
            siparisUrunAdeti.Text = siparisListe.SelectedItems[0].SubItems[3].Text;
            siparisToplamTutar.Text = siparisListe.SelectedItems[0].SubItems[4].Text;
            siparisSiparisSaati.Text = siparisListe.SelectedItems[0].SubItems[5].Text;
            siparisSiparisTarihi.Text = siparisListe.SelectedItems[0].SubItems[6].Text;

        }

        private void anlikSaatgosterge_MouseClick(object sender, MouseEventArgs e)
        {
            siparisSiparisSaati.Text = anlikSaatgosterge.Text.ToString();
        }

        private void anlikTarihgosterge_MouseClick(object sender, MouseEventArgs e)
        {
            siparisSiparisTarihi.Text = anlikTarihgosterge.Text.ToString();
        }
    }
}
