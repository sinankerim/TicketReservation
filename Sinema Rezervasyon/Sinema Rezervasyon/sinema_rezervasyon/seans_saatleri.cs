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
    public partial class seans_saatleri : Form
    {
        public string kullaniciAdi = "";
        public seans_saatleri()
        {
            InitializeComponent();
        }

        SqlDataAdapter adapter;
        DataTable tablo;
        SqlConnection baglanti;
        method_class methodlar = new method_class();

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            seanssaatleri_dgv.ReadOnly =false;
            MessageBox.Show("Yaptığınız değişiklikler geri alınamaz sadece yeniden düzenlenebilir.","Dikkat");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seanssaatleri_dgv.ReadOnly = true;
            MessageBox.Show("Düzenleme Bitirildi","Uyarı");
        }

        private void seans_saatleri_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-AHG4BK6\\SQLEXPRESS01;Initial Catalog=proje_veritabani;Integrated Security=True");

            methodlar.dgvdoldur(seanssaatleri_dgv,"*","seans_saatleri"," ");
        }

        private void seans_saatleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            seans_ekle seansekle_form = new seans_ekle();
            this.Hide();
        }
    }
}
