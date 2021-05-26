using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;












namespace sinema_rezervasyon
{
    class method_class
    {
        SqlDataAdapter adapter;
        DataTable tablo;
        SqlCommand cmd;
        public void cbdoldur(ComboBox cb_adi, string oge, string tablo_adi, string and_where, string cekilecek_adi)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-AHG4BK6\\SQLEXPRESS01;Initial Catalog=proje_veritabani;Integrated Security=True");

            adapter = new SqlDataAdapter("select " + oge + " from " + tablo_adi + " " + and_where + " ", baglanti);
            tablo = new DataTable();


            adapter.Fill(tablo);

            cb_adi.Items.Clear();

            baglanti.Open();

            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                cb_adi.Items.Add(tablo.Rows[i]["" + cekilecek_adi + ""].ToString());
            }

            baglanti.Close();
        }

        public void dgvdoldur(DataGridView dgv_adi, string oge, string tablo_adi, string and_where)
            {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-AHG4BK6\\SQLEXPRESS01;Initial Catalog=proje_veritabani;Integrated Security=True");
            baglanti.Open();
            tablo = new DataTable();
            adapter = new SqlDataAdapter("select "+oge+" from "+tablo_adi+" "+and_where+" ", baglanti);
            adapter.Fill(tablo);
            dgv_adi.DataSource = tablo;
            baglanti.Close();
        }

        public void koltukbos(Button buton_adi)
        {
            buton_adi.BackColor = Color.LimeGreen;
            buton_adi.Enabled = true;
        }

        public void koltukdolu(Button buton_adi)
        {
            buton_adi.BackColor = Color.LightCoral;
            buton_adi.Enabled = false;
        }

        public void kontrol(Button buton_adi,int koltuk_id, string seans_saati)
        {
            DateTime dt = DateTime.Now.Date;
            string tarih = dt.ToString("yyyy-MM-dd HH:mm:ss");

            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-AHG4BK6\\SQLEXPRESS01;Initial Catalog=proje_veritabani;Integrated Security=True");

            
                cmd = new SqlCommand("select * from biletler where  koltuk_id=" + koltuk_id + " and bilet_tarihi='" + tarih + "' and seans_saati='" + seans_saati + "'", baglanti);

                baglanti.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                bool varmi = reader.Read();

                if (varmi)
                {
                    buton_adi.BackColor = Color.Salmon;
                    buton_adi.Enabled = false;
                }
                else
                {
                    buton_adi.BackColor = Color.LimeGreen;
                    buton_adi.Enabled = true;
                }
                baglanti.Close();
            
               
        }

        public void kontrol_deneme(Button buton_adi, int koltuk_id, string seans_saati)
        {
            DateTime dt = DateTime.Now.Date;
            string tarih = dt.ToString("yyyy-MM-dd HH:mm:ss");

            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-AHG4BK6\\SQLEXPRESS01;Initial Catalog=proje_veritabani;Integrated Security=True");

            for (int i=1; i>=40; i++)
            {
                cmd = new SqlCommand("select * from biletler where  koltuk_id="+i+" and bilet_tarihi='"+dt+"' and seans_saati='"+seans_saati+"'", baglanti);

                baglanti.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                bool varmi = reader.Read();

                if (varmi)
                {
                    buton_adi.BackColor = Color.Salmon;
                    buton_adi.Enabled = false;
                }
                else
                {
                    buton_adi.BackColor = Color.LimeGreen;
                    buton_adi.Enabled = true;
                }
                baglanti.Close();
            }


        }


        
        public void bilet(Button koltuk, int seansid,string fiyat,ComboBox seanslar)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-AHG4BK6\\SQLEXPRESS01;Initial Catalog=proje_veritabani;Integrated Security=True");
            DateTime dt = DateTime.Now.Date;
            string tarih = dt.ToString("yyyy-MM-dd HH:mm:ss");
            SqlCommand cmd = new SqlCommand("insert into[biletler](koltuk_id, film_id, seans_id, salon_id, bilet_tarihi, tutar, seans_saati) values((Select koltuk_id from koltuklar where koltuk_adi = '" + koltuk.Text + "' ), (select film_id from seanslar where seans_id = " + seansid + ")," + seansid + ",(select salon_id from seanslar where seans_id = " + seansid + "),'" + tarih + "','"+fiyat+"','" + seanslar.Text + "')", baglanti);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            koltuk.Enabled = false;
            MessageBox.Show("Bilet başarıyla satıldı.","Başarılı");
        }


    }
}
