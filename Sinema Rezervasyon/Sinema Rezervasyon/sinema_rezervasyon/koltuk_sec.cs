using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_rezervasyon
{
    public partial class koltuk_sec : Form
    {
        public koltuk_sec()
        {
            InitializeComponent();
        }

        int tam_sayisi = 0, ogrenci_sayisi = 0;

        private void tam_nud_ValueChanged(object sender, EventArgs e)
        {
            tam_sayisi =(int)tam_nud.Value*15;
            tutar_label.Text = Convert.ToString(tam_sayisi + ogrenci_sayisi)+ " TL";
        }

        private void ogrenci_nud_ValueChanged(object sender, EventArgs e)
        {
            ogrenci_sayisi = (int)ogrenci_nud.Value*10;
            tutar_label.Text = Convert.ToString(tam_sayisi + ogrenci_sayisi) + " TL";
        }

        private void koltuk_sec_Load(object sender, EventArgs e)
        {

        }

        private void koltuksec_b_Click(object sender, EventArgs e)
        {
            if (tam_sayisi != 0 || ogrenci_sayisi != 0) koltuksec_gb.Enabled = true;
            else MessageBox.Show("Lütfen önce kişi sayısını belirleyiniz.","Uyarı");
        }
    }
}
