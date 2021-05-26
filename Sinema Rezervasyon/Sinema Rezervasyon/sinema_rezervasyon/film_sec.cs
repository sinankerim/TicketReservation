using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace sinema_rezervasyon
{
    public partial class film_sec : Form
    {
        public string kullaniciAdi = "";
        public film_sec()
        {
            InitializeComponent();
           
        }

        SqlDataAdapter adapter;
        DataTable tablo;
        SqlConnection baglanti;
        int tam_sayisi = 0, ogrenci_sayisi = 0,count=0,tamsayi_fiyat=0,ogr_fiyat=0;
        method_class methodlar = new method_class();
        string altyazidublaj;
        SqlCommand seans_id_bul;






        private void cinema_Load(object sender, EventArgs e)
        {
            hosgeldiniz_label.Text = "Hoşgeldiniz " + Tag.ToString();
            kullaniciAdi = Tag.ToString();
            baglanti = new SqlConnection("Data Source=DESKTOP-AHG4BK6\\SQLEXPRESS01;Initial Catalog=proje_veritabani;Integrated Security=True");
            
            methodlar.cbdoldur(filmadi_cb,"*","filmler"," ", "film_adi");
            

        }


        private void filmadi_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            altyazidublaj_cb.Items.Clear();
            altyazidublaj_cb.Items.Add("Altyazılı");
            altyazidublaj_cb.Items.Add("Türkçe Dublaj");

            adapter = new SqlDataAdapter("SELECT film_id from filmler where film_adi='" + filmadi_cb.Text + "'", baglanti);
            tablo = new DataTable();
            adapter.Fill(tablo);
            string film_id = Convert.ToString(tablo.Rows[0]["film_id"]);
            
        }


        private void altyazidublaj_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ikiducd_cb.Items.Clear();
            seanslar_cb.Items.Clear();
            ikiducd_cb.Items.Add("2D");
            ikiducd_cb.Items.Add("3D");
            if (altyazidublaj_cb.SelectedItem == "Altyazılı")
            {
                altyazidublaj = "altyazi";
            }
            else
            {
                altyazidublaj = "dublaj";
            }

        }

        private void ikiducd_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Convert.ToString(altyazidublaj_cb.SelectedItem) == "Altyazılı")
            {
                methodlar.cbdoldur(seanslar_cb, "*", "seanslar", " WHERE altyazi_dublaj='altyazi' AND film_id=(select film_id from filmler where film_adi='" + filmadi_cb.Text + "') AND ikiducd='" + ikiducd_cb.Text + "'", "seans_saati");
            }

            else
            {
                methodlar.cbdoldur(seanslar_cb, "*", "seanslar", "WHERE altyazi_dublaj= 'dublaj' AND film_id=(select film_id from filmler where film_adi='"+filmadi_cb.Text+"') AND ikiducd='" + ikiducd_cb.Text + "'", "seans_saati");                
            }            

        }

        private void seanslar_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter seans_id_bul= new SqlDataAdapter("select seans_id from seanslar where film_id=(select film_id from filmler where film_adi='" + filmadi_cb.SelectedItem + "') and altyazi_dublaj='" + altyazidublaj + "' and ikiducd='" + ikiducd_cb.SelectedItem + "' and seans_saati='" + seanslar_cb.SelectedItem + "'", baglanti);
            tablo = new DataTable();
            baglanti.Open();
            seans_id_bul.Fill(tablo);
            int seans_id = Convert.ToInt32(tablo.Rows[0]["seans_id"]);
            baglanti.Close();

            seansid_label.Text =Convert.ToString(seans_id);

        }

        private void filmlerid_b_Click(object sender, EventArgs e)
        {
            this.Hide();
            film_ekle filmekle_form = new film_ekle();
            filmekle_form.Tag = kullaniciAdi;
            filmekle_form.Show();
        }

        private void cikisyap_b_Click(object sender, EventArgs e)
        {
            this.Hide();
            giris giris_form = new giris();
            giris_form.Show();

        }

        private void seanslarıd_b_Click(object sender, EventArgs e)
        {
            this.Hide();
            seans_ekle seansekle_form = new seans_ekle();
            seansekle_form.Tag = kullaniciAdi;
            seansekle_form.Show();
        }

        private void film_sec_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tam_sayisi = (int)tam_nud.Value;
            ogrenci_sayisi = (int)ogrenci_nud.Value;
            if (tam_sayisi == 0 && ogrenci_sayisi == 0)
            {
                MessageBox.Show("Lütfen önce kişi sayısını belirleyiniz.", "Uyarı");
            }

            else
            {
                koltuksec_gb.Enabled = true;
            }

            methodlar.kontrol(koltuk1, 1, seanslar_cb.Text);
            methodlar.kontrol(koltuk2, 2, seanslar_cb.Text);
            methodlar.kontrol(koltuk3, 3, seanslar_cb.Text);
            methodlar.kontrol(koltuk4, 4, seanslar_cb.Text);
            methodlar.kontrol(koltuk5, 5, seanslar_cb.Text);
            methodlar.kontrol(koltuk6, 6, seanslar_cb.Text);
            methodlar.kontrol(koltuk7, 7, seanslar_cb.Text);
            methodlar.kontrol(koltuk8, 8, seanslar_cb.Text);
            methodlar.kontrol(koltuk9, 9, seanslar_cb.Text);
            methodlar.kontrol(koltuk10, 10, seanslar_cb.Text);
            methodlar.kontrol(koltuk11, 11, seanslar_cb.Text);
            methodlar.kontrol(koltuk12, 12, seanslar_cb.Text);
            methodlar.kontrol(koltuk13, 13, seanslar_cb.Text);
            methodlar.kontrol(koltuk14, 14, seanslar_cb.Text);
            methodlar.kontrol(koltuk15, 15, seanslar_cb.Text);
            methodlar.kontrol(koltuk16, 16, seanslar_cb.Text);
            methodlar.kontrol(koltuk17, 17, seanslar_cb.Text);
            methodlar.kontrol(koltuk18, 18, seanslar_cb.Text);
            methodlar.kontrol(koltuk19, 19, seanslar_cb.Text);
            methodlar.kontrol(koltuk20, 20, seanslar_cb.Text);
            methodlar.kontrol(koltuk21, 21, seanslar_cb.Text);
            methodlar.kontrol(koltuk22, 22, seanslar_cb.Text);
            methodlar.kontrol(koltuk23, 23, seanslar_cb.Text);
            methodlar.kontrol(koltuk24, 24, seanslar_cb.Text);
            methodlar.kontrol(koltuk25, 25, seanslar_cb.Text);
            methodlar.kontrol(koltuk26, 26, seanslar_cb.Text);
            methodlar.kontrol(koltuk27, 27, seanslar_cb.Text);
            methodlar.kontrol(koltuk28, 28, seanslar_cb.Text);
            methodlar.kontrol(koltuk29, 29, seanslar_cb.Text);
            methodlar.kontrol(koltuk30, 30, seanslar_cb.Text);
            methodlar.kontrol(koltuk31, 31, seanslar_cb.Text);
            methodlar.kontrol(koltuk32, 32, seanslar_cb.Text);
            methodlar.kontrol(koltuk33, 33, seanslar_cb.Text);
            methodlar.kontrol(koltuk34, 34, seanslar_cb.Text);
            methodlar.kontrol(koltuk35, 35, seanslar_cb.Text);
            methodlar.kontrol(koltuk36, 36, seanslar_cb.Text);
            methodlar.kontrol(koltuk37, 37, seanslar_cb.Text);
            methodlar.kontrol(koltuk38, 38, seanslar_cb.Text);
            methodlar.kontrol(koltuk39, 39, seanslar_cb.Text);
            methodlar.kontrol(koltuk40, 40, seanslar_cb.Text);
            

        }
        private void ogrenci_nud_ValueChanged(object sender, EventArgs e)
        {
            //ogrenci_sayisi = (int)ogrenci_nud.Value;
            ogr_fiyat = (int)ogrenci_nud.Value * 10;
            count = ogrenci_sayisi+tam_sayisi;
            tutar_label.Text = count+" TL";
            tutar_label.Text = Convert.ToString(tamsayi_fiyat + ogr_fiyat) + " TL";
            
        }
        private void tam_nud_ValueChanged(object sender, EventArgs e)
        {
            //tam_sayisi = (int)tam_nud.Value;
            tamsayi_fiyat = (int)tam_nud.Value * 15;
            count = tam_sayisi+ogrenci_sayisi;
            tutar_label.Text = Convert.ToString(tamsayi_fiyat + ogr_fiyat) + " TL";
        }

        private void koltuk1_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk1, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk1, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }
        
        
        
        
        private void koltuk2_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk2, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk2, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }
       
        
        
        
        
        
        private void koltuk3_Click(object sender, EventArgs e)
        {


            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk3,seans_id,"15",seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk3, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }



        }

        private void koltuk4_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk4, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk5_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk5, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk5, seans_id, "10", seanslar_cb);
                koltuk5.Enabled = false;
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk6_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk6, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk6, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk7_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk7, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk7, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk8_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk8, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk8, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk9_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk9, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk9, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk10_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk10, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk10, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk11_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk11, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk11, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk12_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk12, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk12, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk13_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk13, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk13, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk14_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk14, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk14, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk15_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk15, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk15, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk16_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk16, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk16, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk17_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk17, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk17, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk18_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk18, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk18, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk19_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk19, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk19, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk20_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk20, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk20, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk21_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk21, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk21, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk22_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk22, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk22, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk23_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk23, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk23, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk24_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk24, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk24, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk25_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk25, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk25, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk26_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk26, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk26, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk27_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk27, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk27, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk28_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk28, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk28, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk29_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk29, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk29, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk30_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk30, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk30, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk31_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk31, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk31, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk32_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk32, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk32, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk33_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk33, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk33, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk34_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk34, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk34, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk35_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk35, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk35, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk36_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk36, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk36, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        

        private void koltuk37_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk37, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk37, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk38_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk38, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk38, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk39_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk39, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk39, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }

        private void koltuk40_Click(object sender, EventArgs e)
        {
            int seans_id = Convert.ToInt32(seansid_label.Text);
            DateTime dt = DateTime.Now.Date;
            if (tam_sayisi > 0)
            {
                methodlar.bilet(koltuk40, seans_id, "15", seanslar_cb);
                tam_sayisi = (tam_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }


            else if (ogrenci_sayisi > 0)
            {
                methodlar.bilet(koltuk40, seans_id, "10", seanslar_cb);
                ogrenci_sayisi = (ogrenci_sayisi - 1);
                MessageBox.Show("Tam: " + tam_sayisi + " Öğrenci: " + ogrenci_sayisi + "");
                if (tam_sayisi == 0 && ogrenci_sayisi == 0)
                {
                    koltuksec_gb.Enabled = false;
                }

            }
        }



    }
}
