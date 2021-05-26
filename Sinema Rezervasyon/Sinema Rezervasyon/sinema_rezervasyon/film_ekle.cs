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
    public partial class film_ekle : Form
    {
        public string kullaniciAdi = "";
        public film_ekle()
        {
            InitializeComponent();
        }

        SqlDataAdapter adapter;
        DataTable tablo;
        SqlConnection baglanti;
        SqlCommand cmd;
        film_sec filmsec_form = new film_sec();
        SqlDataReader reader;

        method_class methodlar = new method_class();


        private void film_ekle_Load(object sender, EventArgs e)
        {

            kullaniciAdi = Tag.ToString();
            baglanti = new SqlConnection("Data Source=DESKTOP-AHG4BK6\\SQLEXPRESS01;Initial Catalog=proje_veritabani;Integrated Security=True");

            methodlar.dgvdoldur(filmler_dgv,"*","filmler"," ");

            bd_cb.Items.Add("film_adi");
            bd_cb.Items.Add("yas_siniri");
            bd_cb.Items.Add("kac_dk");
            bd_cb.Items.Add("vizyon_baslangic_t");
            bd_cb.Items.Add("vizyon_bitis_t");

        }

        private void film_ekle_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            film_sec filmsec_form = new film_sec();
            filmsec_form.Tag = kullaniciAdi;
            filmsec_form.Show();
        }

        //KEYPRESS GRUBU

        private void feyassiniri_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void fekacdk_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void bdid_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void fsfilmid_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //KEYPRESS GRUBU


        private void guncelle_b_Click(object sender, EventArgs e)
        {
            if(bd_cb.Text=="" || bdfilmid_txt.Text=="" || bdyeniveri_txt.Text=="")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.","Uyarı");
            }

            else
            {
                try
                {
                    baglanti.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE filmler SET " + bd_cb.Text + " = '" + bdyeniveri_txt.Text + "' WHERE film_id=" + Convert.ToInt32(bdfilmid_txt.Text) + "", baglanti);
                    cmd.ExecuteNonQuery();

                    methodlar.dgvdoldur(filmler_dgv, "*", "filmler", " ");

                    baglanti.Close();

                    MessageBox.Show("Güncelleme başarılı!","Başarılı");
                }
                catch(Exception)
                {
                    MessageBox.Show("Bir hata oluştu lütfen girdiğiniz bilgileri kontrol ediniz.");
                }
            }
        }

        private void filmsil_b_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from kullanicilar where kullanici_adi='" + kullaniciAdi+"' AND sifre='"+fssifre_txt.Text+"'",baglanti);
            

            baglanti.Open();
            reader = cmd.ExecuteReader();
            bool mevcut = reader.Read();
            baglanti.Close();


            if (fsfilmid_txt.Text == "" || fssifre_txt.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz.", "Uyarı");
                baglanti.Close();
            }

            else if (mevcut)
            {

                baglanti.Close();
                cmd = new SqlCommand("delete from filmler where film_id=" + Convert.ToInt32(fsfilmid_txt.Text) + " ", baglanti);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Film başarıyla silindi!", "Başarılı!");

                methodlar.dgvdoldur(filmler_dgv, "*", "filmler", " ");
                
            }
            else
            {
                baglanti.Close();
                MessageBox.Show("Şifreniz yanlış","Uyarı");
            }

        }

        private void filmekle_b_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from filmler where film_adi='"+fefilmadi_txt.Text+"'",baglanti);
            baglanti.Open();
            reader = cmd.ExecuteReader();
            bool mevcut = reader.Read();
            baglanti.Close();
            string fevbaslangicvr = fevbaslangict_dtp.Value.ToString("yyyy-MM-dd");
            string fevbitisvr = fevbitist_dtp.Value.ToString("yyyy-MM-dd");
            TimeSpan span = fevbitist_dtp.Value.Date-fevbaslangict_dtp.Value.Date;
          
            

            if (fefilmadi_txt.Text == "" || fekacdk_txt.Text == "" || Convert.ToString(fevbaslangict_dtp) == "" || Convert.ToString(fevbitist_dtp) == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Boş alan!");
            }
            
           else if (mevcut)
            {
                MessageBox.Show("Böyle bir film adı mevcut. Lütfen eklemek istediğiniz filmin adını tekrar kontrol edin.", "Dikkat");
            
            }

            else if (Convert.ToInt32(span.Days)<=0)
            {
                MessageBox.Show("Vizyon bitiş tarihiniz başlangıç tarihiyle aynı veya daha erken olamaz. Lütfen girdiğiniz verileri kontrol edin.","Uyarı");
            }
            
            else 
            {
                cmd = new SqlCommand("insert into [filmler] (film_adi,yas_siniri,kac_dk,vizyon_baslangic_t,vizyon_bitis_t) values ('"+Convert.ToString(fefilmadi_txt.Text)+"',"+Convert.ToInt32(feyassiniri_txt.Text)+","+fekacdk_txt.Text+",'"+ fevbaslangicvr + "','" + fevbitisvr + "')", baglanti);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Film başarıyla eklendi!");

                methodlar.dgvdoldur(filmler_dgv, "*", "filmler", " ");
            }
            baglanti.Close();
        }

        private void filmler_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //var dataIndexNo = filmler_dgv.Rows[e.RowIndex].Index.ToString();
            //string film_adi = filmler_dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            //string yas_siniri = filmler_dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            //string kac_dk = filmler_dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            //string vizyon_baslangic_t = filmler_dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            //string vizyon_bitis_t = filmler_dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            //fefilmadi_txt.Text = film_adi;
            //feyassiniri_txt.Text = yas_siniri;
            //fekacdk_txt.Text = kac_dk;
            //fevbaslangict_dtp.Value = Convert.ToDateTime(vizyon_baslangic_t);
            //fevbitist_dtp.Value = Convert.ToDateTime(vizyon_bitis_t);
            //MessageBox.Show("naber!");

            //Convert.ToInt32
        }
    }
}
