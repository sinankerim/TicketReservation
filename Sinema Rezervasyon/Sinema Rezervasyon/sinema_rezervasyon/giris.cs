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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        SqlDataAdapter adapter;
        DataTable tablo;
        SqlConnection baglanti;
        SqlCommand cmd;
        SqlDataReader reader;
        
        

        public string kadi_veri;

         
        private void girisyap_b_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from kullanicilar where kullanici_adi='"+kadi_txt.Text+"' AND sifre='"+sifre_txt.Text+"' ",baglanti);
            baglanti.Open();
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                this.Hide();
                film_sec filmsec_form = new film_sec();
                //kadi_veri =kadi_txt.Text;
                filmsec_form.Tag = kadi_txt.Text;
                filmsec_form.Show();
            }
            else 
            {
                MessageBox.Show("Kullanıcı adı veya şifreniz hatalı.","Uyarı");
            }
            baglanti.Close();


        }

        private void giris_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-AHG4BK6\\SQLEXPRESS01;Initial Catalog=proje_veritabani;Integrated Security=True");
        }

        

        private void kadi_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                girisyap_b.PerformClick();
            }
        }

        private void sifre_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                girisyap_b.PerformClick();
            }
        }

    }
}
