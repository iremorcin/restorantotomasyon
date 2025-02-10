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
    public partial class zraporformu : Form
    {
        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=RestorantOtomasyon;Integrated Security=True;");


        public zraporformu()
        {
            InitializeComponent();
        }
        private void raporAra()
        {
            zraporListe.Items.Clear();
            zraporListe.View = View.Details;
            zraporListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand raporAra = new SqlCommand("select * from zraporformu where Rapor_no =" + zraporRaporNo.Text + "'", sqlBaglanti);
            SqlDataReader oku = raporAra.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["Rapor_no"].ToString());
                item.SubItems.Add(oku["Odeme_nolari"].ToString());
                item.SubItems.Add(oku["Rapor_tarihi"].ToString());
                item.SubItems.Add(oku["Top_satis"].ToString());
                item.SubItems.Add(oku["islem_sayisi"].ToString());
                zraporListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }
        private void raporListele()
        {
            zraporListe.Items.Clear();
            zraporListe.View = View.Details;
            zraporListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand raporListele = new SqlCommand("select * from zraporformu", sqlBaglanti);
            SqlDataReader oku = raporListele.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["Rapor_no"].ToString());
                item.SubItems.Add(oku["Odeme_nolari"].ToString());
                item.SubItems.Add(oku["Rapor_tarihi"].ToString());
                item.SubItems.Add(oku["Top_satis"].ToString());
                item.SubItems.Add(oku["islem_sayisi"].ToString());
                zraporListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }
        private void raporTemizle()
        {
            zraporRaporNo.Text = "";
            zraporOdemeNo.Text = "";   
            zraporRaporTarihi.Text = "";
            zraporToplamSatis.Text = "";
            zraporislemSayisi.Text = "";
        }





        private void anlikTarihSaatzrapor_Tick(object sender, EventArgs e)
        {
            anlikSaatgosterge.Text = DateTime.Now.ToLongTimeString();
            anlikTarihgosterge.Text = DateTime.Now.ToLongDateString();
        }

        private void zraporformu_Load(object sender, EventArgs e)
        {
            anlikTarihSaatzrapor.Start();
            raporListele();
        }

        private void zraporAra_Click(object sender, EventArgs e)
        {
            raporAra();
        }

        private void zraporEkle_Click(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            string raporekle = "insert into zraporformu (Rapor_no,Odeme_nolari, Rapor_tarihi, Top_satis, islem_sayisi) values (@p1,@p2,@p3,@p4,@p5)";
            SqlCommand ekle = new SqlCommand(raporekle, sqlBaglanti);
            ekle.Parameters.AddWithValue("@p1", zraporRaporNo.Text);
            ekle.Parameters.AddWithValue("@p2", zraporRaporNo.Text);
            ekle.Parameters.AddWithValue("@p3", zraporRaporTarihi.Text);
            ekle.Parameters.AddWithValue("@p4", zraporToplamSatis.Text);
            ekle.Parameters.AddWithValue("@p5", zraporislemSayisi.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("Rapor ekleme başarıyla gerçekleşmiştir.");
            sqlBaglanti.Close();
            raporListele();
            raporTemizle();
        }

        private void zraporGuncelle_Click(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            SqlCommand raporGuncelle = new SqlCommand("UPDATE zraporformu SET Rapor_tarihi = '" + zraporRaporTarihi.Text + "', Odeme_nolari = '" + zraporOdemeNo.Text +
                "', Top_satis = '" + zraporToplamSatis.Text + "', islem_sayisi = '" + zraporislemSayisi.Text +
                "' WHERE Rapor_no  = '" + zraporRaporNo.Text + "'", sqlBaglanti);
            raporGuncelle.ExecuteNonQuery();
            MessageBox.Show("Rapor düzenleme başarıyla gerçekleşmiştir.");
            sqlBaglanti.Close();
            raporListele();
            raporTemizle();
        }

        private void zraporSil_Click(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            SqlCommand raporsil = new SqlCommand("Delete FROM zraporformu WHERE Rapor_no = '" + zraporRaporNo.Text + "'", sqlBaglanti);
            raporsil.ExecuteNonQuery();
            MessageBox.Show("Rapor kaydı başarıyla silinmiştir.");
            sqlBaglanti.Close();
            raporListele();
            raporTemizle();
        }

        private void zraporListe_MouseClick(object sender, MouseEventArgs e)
        {
            zraporRaporNo.Text = zraporListe.SelectedItems[0].SubItems[0].Text;
            zraporOdemeNo.Text = zraporListe.SelectedItems[0].SubItems[1].Text;
            zraporRaporTarihi.Text = zraporListe.SelectedItems[0].SubItems[2].Text;
            zraporToplamSatis.Text = zraporListe.SelectedItems[0].SubItems[3].Text;
            zraporislemSayisi.Text = zraporListe.SelectedItems[0].SubItems[4].Text;
        }

        private void anlikTarihgosterge_MouseClick(object sender, MouseEventArgs e)
        {
           zraporRaporTarihi.Text = anlikTarihgosterge.Text.ToString();
        }
    }
}
