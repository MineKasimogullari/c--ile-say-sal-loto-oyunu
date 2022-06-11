using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayısal_Loto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] textdizi = new int[6];
            textdizi[0] = Convert.ToInt32(textBox1.Text);
            textdizi[1] = Convert.ToInt32(textBox2.Text);
            textdizi[2] = Convert.ToInt32(textBox3.Text);
            textdizi[3] = Convert.ToInt32(textBox4.Text);
            textdizi[4] = Convert.ToInt32(textBox5.Text);
            textdizi[5] = Convert.ToInt32(textBox6.Text);
            Random rastgele = new Random();
            int r;
            int j = 0;
            int[] dizi = new int[6];
            if (textdizi[0]<50&& textdizi[1] < 50 && textdizi[2] < 50 && textdizi[3] < 50 && textdizi[4] < 50 && textdizi[5] < 50)
            {
                while (j < 6)
                {
                    r = rastgele.Next(1, 50);
                    if (Array.IndexOf(dizi, r) == -1)
                    {
                        dizi[j] = r;
                        j++;
                    }
                }
                int sonuc = 0;
                Array.Sort(dizi);
                label3.Text = dizi[0].ToString();
                label4.Text = dizi[1].ToString();
                label5.Text = dizi[2].ToString();
                label6.Text = dizi[3].ToString();
                label7.Text = dizi[4].ToString();
                label8.Text = dizi[5].ToString();
                for (int i = 0; i < 6; i++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        if (dizi[i] == textdizi[k])
                        {
                            sonuc += 1;
                        }
                    }
                }
                if (sonuc < 3)
                {
                    MessageBox.Show("Malesef " + sonuc + " Adet Tutturdunuz.");
                }
                else
                {
                    MessageBox.Show("Tebrikler " + sonuc + " Adet Tutturdunuz.");
                }
            }
            else
            {
                MessageBox.Show("1-49 arasında sayı giriniz...");
            }
            
        }
    }
}
