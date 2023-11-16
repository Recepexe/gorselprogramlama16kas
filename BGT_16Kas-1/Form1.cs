using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGT_16Kas_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fiyat1;
            double etiketFiyat;
            fiyat1 = Convert.ToInt32(textBox1.Text);
            etiketFiyat = fiyat1 * 0.75;
            labelEtiket.Text = etiketFiyat.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fiyat1;
            double etiketFiyat;
            fiyat1 = Convert.ToInt32(textBox1.Text);
            etiketFiyat = fiyat1 * 0.5;
            labelEtiket.Text = etiketFiyat.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int fiyat1;
            double etiketFiyat;
            fiyat1 = Convert.ToInt32(textBox1.Text);
            etiketFiyat = fiyat1 * 1.25;
            labelEtiket.Text = etiketFiyat.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int fiyat1;
            double etiketFiyat;
            fiyat1 = Convert.ToInt32(textBox1.Text);
            etiketFiyat = fiyat1 * 1.5;
            labelEtiket.Text = etiketFiyat.ToString();
        }









        private void Form1_Load(object sender, EventArgs e)
        {
            //2-Değişken Oluştur
            //fiyat1 int, etiketFiyat double
            int fiyat1;
            double etiketFiyat;

            //3-fiyat1 e Textbox daki yazıyı
            //aktar
            fiyat1 = Convert.ToInt32(textBox1.Text);

            //4- etiketFiyatı Hesapla
            etiketFiyat = fiyat1 * 0.7;

            //5-label'a etiketFiyatı yazdır
            labelEtiket.Text = etiketFiyat.ToString();



        }
    }
}
