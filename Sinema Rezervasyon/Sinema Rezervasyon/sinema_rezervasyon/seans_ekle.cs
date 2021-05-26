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


namespace sinema_rezervasyon
{
    public partial class seans_ekle : Form
    {
        public string kullaniciAdi = "";
        public seans_ekle()
        {
            InitializeComponent();
        }

        method_class methodlar = new method_class();

        SqlCommand cmd;
        SqlConnection baglanti;



        private void seans_ekle_Load(object sender, EventArgs e)
        {
            kullaniciAdi = Tag.ToString();
            methodlar.dgvdoldur(seanslar_dgv, "*", "seanslar", " ");
            methodlar.cbdoldur(sefilm_cb,"*","filmler"," ","film_adi");
            //ssseansid_label.Text = kullaniciAdi;


            baglanti = new SqlConnection("Data Source=DESKTOP-AHG4BK6\\SQLEXPRESS01;Initial Catalog=proje_veritabani;Integrated Security=True");
            
        }

        private void seans_ekle_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            film_sec filmsec_form = new film_sec();
            filmsec_form.Tag = kullaniciAdi;
            filmsec_form.Show();
        }

        private void ssseansid_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void sefilm_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            methodlar.cbdoldur(sesalon_cb,"*","salonlar"," ","salon_adi");
        }

        private void sesalon_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            methodlar.cbdoldur(seseanssaati_cb,"*","seans_saatleri"," ","seans_saati");
        }

        private void seseanssaati_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            sealtyazidublaj_cb.Items.Clear();
            sealtyazidublaj_cb.Items.Add("Altyazılı");
            sealtyazidublaj_cb.Items.Add("Türkçe Dublaj");
        }

        private void sealtyazidublaj_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            seikiducd_cb.Items.Clear();
            seikiducd_cb.Items.Add("2D");
            seikiducd_cb.Items.Add("3D");
        }
        //and salon_id=(select salon_adi from salonlar where salon_id="+sesalon_cb.Text+")
        private void seseansekle_b_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from seanslar where salon_id=(select salon_id from salonlar where salon_adi='" + sesalon_cb.Text+"') and seans_saati='"+seseanssaati_cb.Text+"' and ikiducd='"+seikiducd_cb.Text+"'", baglanti);
            baglanti.Open();
            SqlDataReader reader=cmd.ExecuteReader();
            bool mevcut = reader.Read();



            if (sefilm_cb.Text == "" || sesalon_cb.Text == "" || seseanssaati_cb.Text == "" || sealtyazidublaj_cb.Text == "" || seikiducd_cb.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı");
                baglanti.Close();
            }
            else if (mevcut)
            {
                MessageBox.Show("Böyle bir seans mevcut", "Uyarı");
                baglanti.Close();
            }
            else
            {
                baglanti.Close();
                baglanti.Open();
                if (sealtyazidublaj_cb.Text == "Altyazılı")
                {
                    cmd = new SqlCommand("insert into [seanslar] (film_id,salon_id,seans_saati,altyazi_dublaj,ikiducd) values((select film_id from filmler where film_adi='" + sefilm_cb.Text + "'),(select salon_id from salonlar where salon_adi='" + sesalon_cb.Text + "'),'" + seseanssaati_cb.Text + "','altyazi','" + seikiducd_cb.Text + "')", baglanti);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seans başarıyla eklendi!", "Uyarı");
                    methodlar.dgvdoldur(seanslar_dgv, "*", "seanslar", " ");
                    baglanti.Close();
                }
                else 
                {
                    cmd = new SqlCommand("insert into [seanslar] (film_id,salon_id,seans_saati,altyazi_dublaj,ikiducd) values((select film_id from filmler where film_adi='" + sefilm_cb.Text + "'),(select salon_id from salonlar where salon_adi='" + sesalon_cb.Text + "'),'" + seseanssaati_cb.Text + "','dublaj','" + seikiducd_cb.Text + "')", baglanti);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seans başarıyla eklendi!", "Uyarı");
                    methodlar.dgvdoldur(seanslar_dgv, "*", "seanslar", " ");
                    baglanti.Close();
                }


                //baglanti.Close();
                //baglanti.Open();
                //cmd = new SqlCommand("insert into [seanslar] (film_id,salon_id,seans_saati,altyazi_dublaj,ikiducd) values((select film_id from filmler where film_adi='"+sefilm_cb.Text+"'),(select salon_id from salonlar where salon_adi='"+sesalon_cb.Text+"'),'"+seseanssaati_cb.Text+"','altyazi','"+seikiducd_cb.Text+"')",baglanti);
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("Seans başarıyla eklendi!","Uyarı");
                //methodlar.dgvdoldur(seanslar_dgv,"*","seanslar"," ");
                //baglanti.Close();
            }
        }

        private void seanssil_b_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("select * from kullanicilar where kullanici_adi='" + kullaniciAdi + "' AND sifre='" + sssifre_txt.Text + "'", baglanti);


            baglanti.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            bool mevcut = reader.Read();
            baglanti.Close();


            if (ssseansid_txt.Text == "" || sssifre_txt.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz.", "Uyarı");
                baglanti.Close();
            }

            else if (mevcut)
            {

                baglanti.Close();
                cmd = new SqlCommand("delete from filmler where film_id=" + Convert.ToInt32(ssseansid_txt.Text) + " ", baglanti);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Seans başarıyla silindi!", "Başarılı!");

                methodlar.dgvdoldur(seanslar_dgv, "*", "filmler", " ");

            }
            else
            {
                baglanti.Close();
                MessageBox.Show("Şifreniz yanlış", "Uyarı");
            }
        }

        private void sd_b_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yaptığınız değişiklikler geri alınamaz, sadece yeniden düzenlenebilir.","Dikkat");
            seanslar_dgv.ReadOnly=false;
        }

        private void db_b_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Düzenleme bitirildi.","Uyarı");
            seanslar_dgv.ReadOnly =true;
        }

        private void ssduzenle_b_Click(object sender, EventArgs e)
        {
            
            seans_saatleri seanssaatleri_form = new seans_saatleri();
            seanssaatleri_form.Show();
        }
    }
}
