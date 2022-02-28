using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders1
{
    public partial class Form1 : Form
    {
        int birinciSayi,ikinciSayi;
        int esittir;
        string islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ikinciSayi = Convert.ToInt32(textBox1.Text);

            if(islem=="+")
            {
                esittir = (birinciSayi + ikinciSayi);
                textBox1.Text = Convert.ToString(esittir);
                birinciSayi = esittir;
            }
            if(islem=="-")
            {
                esittir = (birinciSayi - ikinciSayi);
                textBox1.Text = Convert.ToString(esittir);
                birinciSayi = esittir;
            }
            if(islem=="*")
            {
                esittir = (birinciSayi * ikinciSayi);
                textBox1.Text = Convert.ToString(esittir);
                birinciSayi = esittir;
            }
            if (islem == "/")
            {
                if (ikinciSayi == 0)
                {
                    textBox1.Text = "Islem basarisiz";
                }
                else
                {
                    esittir = (birinciSayi / ikinciSayi);
                    textBox1.Text = Convert.ToString(esittir);
                    birinciSayi = esittir;
                }
            }
          
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            birinciSayi = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "0";
            islem = "+";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void cikar_Click(object sender, EventArgs e)
        {
            birinciSayi = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "0";
            islem = "-";
        }

        private void carp_Click(object sender, EventArgs e)
        {
            birinciSayi = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "0";
            islem = "*";
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void bol_Click(object sender, EventArgs e)
        {
            birinciSayi = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "0";
            islem = "/";
        }
    }
}
