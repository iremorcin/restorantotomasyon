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
    public partial class Anasayfa : Form
    {
        private bool masatdown;
        private bool siparisdown;
        private bool rapordown;


        public Anasayfa()
        {
            InitializeComponent();
        }
     

      

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            anasayfaAnlikSaatTarih.Start();
        }

        private void anasayfaAnlikSaatTarih_Tick(object sender, EventArgs e)
        {
            anlikSaatgosterge.Text = DateTime.Now.ToLongTimeString();
            anlikTarihgosterge.Text = DateTime.Now.ToLongDateString();
        }

        private void masaislemDrop_Tick(object sender, EventArgs e)
        {
            if (masatdown)
            {
                masaislemPanel.Height -= 10;
                if (masaislemPanel.Size == masaislemPanel.MinimumSize)
                {
                    masaislemDrop.Stop();
                    masatdown = false;
                }
            }
            else
            {
                masaislemPanel.Height += 10;
                if (masaislemPanel.Size == masaislemPanel.MaximumSize)
                {
                    masaislemDrop.Stop();
                    masatdown = true;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            masaislemDrop.Start();
        }

        private void siparisislemDrop_Tick(object sender, EventArgs e)
        {
            if (siparisdown)
            {
                siparisislemPanel.Height -= 10;
                if (siparisislemPanel.Size == siparisislemPanel.MinimumSize)
                {
                    siparisislemDrop.Stop();
                    siparisdown = false;
                }
            }
            else
            {
                siparisislemPanel.Height += 10;
                if (siparisislemPanel.Size == siparisislemPanel.MaximumSize)
                {
                    siparisislemDrop.Stop();
                    siparisdown = true;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            siparisislemDrop.Start();
        }

        private void raporislemDrop_Tick(object sender, EventArgs e)
        {
            if (rapordown)
            {
                raporislemPanel.Height -= 10;
                if (raporislemPanel.Size == raporislemPanel.MinimumSize)
                {
                    raporislemDrop.Stop();
                    rapordown = false;
                }
            }
            else
            {
                raporislemPanel.Height += 10;
                if (raporislemPanel.Size == raporislemPanel.MaximumSize)
                {
                    raporislemDrop.Stop();
                    rapordown = true;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            raporislemDrop.Start();
        }

        private void masalar_Click(object sender, EventArgs e)
        {
            masalarformu frm = new masalarformu();
            frm.Show();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuformu frm = new menuformu();
            frm.Show();
        }

        private void siparis_Click(object sender, EventArgs e)
        {
            siparisformu frm = new siparisformu();
            frm.Show();
        }

        private void satis_Click(object sender, EventArgs e)
        {
            satisformu frm = new satisformu();
            frm.Show();
        }

        private void stok_Click(object sender, EventArgs e)
        {
            stokekrani frm = new stokekrani();
            frm.Show();
        }

        private void zrapor_Click(object sender, EventArgs e)
        {
            zraporformu frm = new zraporformu();
            frm.Show();
        }
    }
}
