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
    public partial class satisformu : Form
    {
        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=RestorantOtomasyon;Integrated Security=True;");

        public satisformu()
        {
            InitializeComponent();
        }

        private void satisListele()
        {
            satisListe.Items.Clear();
            satisListe.View = View.Details;
            satisListe.FullRowSelect = true;

            
            sqlBaglanti.Open();
            SqlCommand satisListele2 = new SqlCommand("select * from satisformu", sqlBaglanti);
            SqlDataReader oku2 = satisListele2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem item = new ListViewItem(oku2["Siparis_no"].ToString());
                item.SubItems.Add(oku2["Odeme_no"].ToString());
                item.SubItems.Add(oku2["Masa_No"].ToString());
                item.SubItems.Add(oku2["Odeme_turu"].ToString());
                item.SubItems.Add(oku2["Tutar"].ToString());
                satisListe.Items.Add(item);
            }
            sqlBaglanti.Close();

            
        }
        private void satislariAra()
        {
            satisListe.Items.Clear();
            satisListe.View = View.Details;
            satisListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand satisListele = new SqlCommand("SELECT * FROM satisformu where Odeme_no = '" + satisOdemeNo.Text + "'", sqlBaglanti);
            SqlDataReader oku = satisListele.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["Odeme_no"].ToString());
                item.SubItems.Add(oku["Masa_no"].ToString());
                item.SubItems.Add(oku["Odeme_turu"].ToString());
                item.SubItems.Add(oku["Tutar"].ToString());
                satisListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }
        private void satisTemizle() 
        {
            satisOdemeNo.Text = "";
            satisMasaNo.Text = "";
            satisSiparisNo.Text = "";
            satisOdemeTuru.Text = "";
            satisToplamTutar.Text = "";
            satisOdemeNo.Focus();
        }




        private void anlikSaatTarih_Tick(object sender, EventArgs e)
        {
            anlikSaatgosterge.Text = DateTime.Now.ToLongTimeString();
            anlikTarihgosterge.Text = DateTime.Now.ToLongDateString();
        }

        private void satisformu_Load(object sender, EventArgs e)
        {
            anlikSaatTarih.Start();
            satisListele();
        }

        private void satisAra_Click(object sender, EventArgs e)
        {
            satislariAra();
        }

        private void satisEkle_Click(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            string satisEkle = "insert into satisformu (Odeme_no, Siparis_no, Masa_no, Odeme_turu, Tutar) values (@p1,@p2,@p3,@p4,@p5)";
            SqlCommand ekle = new SqlCommand(satisEkle, sqlBaglanti);
            ekle.Parameters.AddWithValue("@p1", satisOdemeNo.Text);
            ekle.Parameters.AddWithValue("@p2", satisOdemeNo.Text);
            ekle.Parameters.AddWithValue("@p3", satisMasaNo.Text);
            ekle.Parameters.AddWithValue("@p4", satisOdemeTuru.Text);
            ekle.Parameters.AddWithValue("@p5", satisToplamTutar.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("Satış başarıyla gerçekleşmiştir.");
            sqlBaglanti.Close();
            satisListele();
            satisTemizle();
        }

        private void satisGuncelle_Click(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            SqlCommand satisGuncelle = new SqlCommand("UPDATE satisformu SET Siparis_no = '" + satisSiparisNo.Text + "', Masa_no = '"
            + satisMasaNo.Text + "', Odeme_turu = '" + satisOdemeTuru.Text + "', Tutar = '" + satisToplamTutar.Text + "' WHERE Odeme_no = '" + satisOdemeNo.Text + "'", sqlBaglanti);
            satisGuncelle.ExecuteNonQuery();
            MessageBox.Show("Satış güncellemesi başarıyla gerçekleşti.");
            sqlBaglanti.Close();
            satisListele();
            satisTemizle();
        }

        private void satisSil_Click(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            SqlCommand satisSil = new SqlCommand("Delete FROM satisformu WHERE Odeme_no = '" + satisOdemeNo.Text + "'", sqlBaglanti);
            satisSil.ExecuteNonQuery();
            MessageBox.Show("Satış kaydı başarıyla silinmiştir.");
            sqlBaglanti.Close();
            satisListele();
            satisTemizle();
        }

        private void satisListe_MouseClick(object sender, MouseEventArgs e)
        {
            satisSiparisNo.Text = satisListe.SelectedItems[0].SubItems[0].Text;
            satisOdemeNo.Text = satisListe.SelectedItems[0].SubItems[1].Text;
            satisMasaNo.Text = satisListe.SelectedItems[0].SubItems[2].Text;
            satisOdemeTuru.Text = satisListe.SelectedItems[0].SubItems[3].Text;
            satisToplamTutar.Text = satisListe.SelectedItems[0].SubItems[4].Text;
        }
    }
}
