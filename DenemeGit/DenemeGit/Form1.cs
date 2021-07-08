using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenemeGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {

            Hesapla();
            Temizle();

        }

        public void Hesapla()
        {
            int sinav1, sinav2;
            float sonuc;

            sinav1 = Convert.ToInt32(tbx_1.Text);
            sinav2 = Convert.ToInt32(tbx_2.Text);

            sonuc = (sinav1 + sinav2) / 2;
            label3.Text = Convert.ToString(sonuc);
            label3.Visible = true;

        }


        public void Temizle()
        {
            tbx_1.Clear();
            tbx_2.Clear();
        }

    }
}
