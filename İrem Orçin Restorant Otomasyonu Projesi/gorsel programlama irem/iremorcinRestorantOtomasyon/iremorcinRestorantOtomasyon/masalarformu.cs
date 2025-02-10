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
    public partial class masalarformu : Form
    {
        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=RestorantOtomasyon;Integrated Security=True;");


        public masalarformu()
        {
            InitializeComponent();
        }

        private void masaAra()
        {
            masalarListe.Items.Clear();
            masalarListe.View = View.Details;
            masalarListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand masaAra = new SqlCommand("SELECT * FROM masalarformu WHERE Masa_numarasi = '" + masalarMasaNo.Text + "'", sqlBaglanti);
            SqlDataReader oku = masaAra.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["Masa_numarasi"].ToString());
                item.SubItems.Add(oku["Masa_kapasite"].ToString());
                item.SubItems.Add(oku["Masa_durum"].ToString());
                item.SubItems.Add(oku["Masa_rezervasyon_durumu"].ToString());
                masalarListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }
        private void masaListele()
        {
            masalarListe.Items.Clear();
            masalarListe.View = View.Details;
            masalarListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand masaListele = new SqlCommand("SELECT * FROM masalarformu", sqlBaglanti);
            SqlDataReader oku = masaListele.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["Masa_numarasi"].ToString());
                item.SubItems.Add(oku["Masa_kapasite"].ToString());
                item.SubItems.Add(oku["Masa_durum"].ToString());
                item.SubItems.Add(oku["Masa_rezervasyon_durumu"].ToString());
                masalarListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }
        private void masaTemizle()
        {
            masalarMasaNo.Text = "";
            masalarMasaKapasite.Text = "";
            masalarMasaDurum.Text = "";
            masalarMasaRezerve.Text = "";
            masalarMasaNo.Focus();
        }
        


        private void masalarformu_Load(object sender, EventArgs e)
        {
            masalaranlıkSaat.Start();
            masaListele();
        }
        private void masalaranlıkSaat_Tick(object sender, EventArgs e)
        {
            anlikSaatgosterge.Text = DateTime.Now.ToLongTimeString();
            anlikTarihgosterge.Text = DateTime.Now.ToLongDateString();
        }
        private void masalarAra_Click(object sender, EventArgs e)
        {
            masaAra();
        }
        private void masalarEkle_Click(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            string masaEkle = "insert into masalarformu (Masa_numarasi, Masa_kapasite, Masa_durum, Masa_rezervasyon_durumu) values (@p1,@p2,@p3,@p4)";
            SqlCommand ekle = new SqlCommand(masaEkle, sqlBaglanti);
            ekle.Parameters.AddWithValue("@p1", masalarMasaNo.Text);
            ekle.Parameters.AddWithValue("@p2", masalarMasaKapasite.Text);
            ekle.Parameters.AddWithValue("@p3", masalarMasaDurum.Text);
            ekle.Parameters.AddWithValue("@p4", masalarMasaRezerve.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("Masa kaydı başarıyla gerçekleşmiştir.");
            sqlBaglanti.Close();
            masaListele();
            masaTemizle();
        }
        private void masalarGuncelle_Click(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            SqlCommand masaGuncelle = new SqlCommand("UPDATE masalarformu SET Masa_numarasi = '" + masalarMasaNo.Text + "', Masa_durum= '" + masalarMasaDurum.Text + "',  Masa_kapasite = '"
            + masalarMasaKapasite.Text + "', Masa_rezervasyon_durumu = '" + masalarMasaRezerve.Text + "' WHERE Masa_numarasi = '" + masalarMasaNo.Text + "'", sqlBaglanti);
            masaGuncelle.ExecuteNonQuery();
            MessageBox.Show("Masa güncelleme başarıyla gerçekleşmiştir.");
            sqlBaglanti.Close();
            masaListele();
            masaTemizle();
        }
        private void masalarSil_Click(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            SqlCommand masaSil = new SqlCommand("Delete FROM masalarformu WHERE Masa_numarasi = '" + masalarMasaNo.Text +"'", sqlBaglanti);
            masaSil.ExecuteNonQuery();
            MessageBox.Show("Masa kaydı başarıyla silinmiştir.");
            sqlBaglanti.Close();
            masaListele();
            masaTemizle();
        }
        private void masalarListe_MouseClick(object sender, MouseEventArgs e)
        {
            masalarMasaNo.Text = masalarListe.SelectedItems[0].SubItems[0].Text;
            masalarMasaDurum.Text = masalarListe.SelectedItems[0].SubItems[1].Text;
            masalarMasaKapasite.Text = masalarListe.SelectedItems[0].SubItems[2].Text;
            masalarMasaRezerve.Text = masalarListe.SelectedItems[0].SubItems[3].Text;
        } 
    }
}
