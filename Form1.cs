using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        double s;
        private void button14_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox3.Text);
            double c = Convert.ToDouble(textBox2.Text);
             s = m + c;
            textBox1.Text = s.ToString();  

        }

        private void button18_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            int c = 0;
            textBox2.Text = c.ToString();
            textBox3.Text = c.ToString();
            textBox1 .Text = c.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox3.Text);
            double c = Convert.ToDouble(textBox2.Text);
            s = m - c;
            textBox1.Text = s.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox3.Text);
            double c = Convert.ToDouble(textBox2.Text);
            s = m * c;
            textBox1.Text = s.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox3.Text);
            double c = Convert.ToDouble(textBox2.Text);
            s = m / c;
            textBox1.Text = s.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox3.Text);
            double c = Convert.ToDouble(textBox2.Text);
            s = m % c;
            textBox1.Text = s.ToString();
        }
        double z;
        private void button6_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox3.Text);
            double c = Convert.ToDouble(textBox2.Text);
            if (m == 0)
            {
                s = Math.Pow(c, 2);
                textBox1.Text = s.ToString();
            }
            else if(c == 0)
            {
                s = Math.Pow(m, 2);
                textBox1.Text = s.ToString();
            }
            else
            {
                s = Math.Pow(c, 2);
                z  = Math.Pow(m, 2);
                textBox1.Text = z.ToString() + "  &&  " + s.ToString();
            }

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox3.Text);
            double c = Convert.ToDouble(textBox2.Text);
            if (m == 0)
            {
                s = Math.Sqrt(c);
                textBox1.Text = s.ToString();
            }
            else if (c == 0)
            {
                s = Math.Sqrt(m);
                textBox1.Text = s.ToString();
            }
            else
            {
                s = Math.Sqrt(c);
                z = Math.Sqrt(m);
                textBox1.Text = z.ToString() + "  &&  " + s.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox3.Text);
            double c = Convert.ToDouble(textBox2.Text);
            if (m == 0)
            {
                s = Math.Sin(c);
                textBox1.Text = s.ToString();
            }
            else if (c == 0)
            {
                s = Math.Sin(m);
                textBox1.Text = s.ToString();
            }
            else
            {
                s = Math.Sin(c);
                z = Math.Sin(m);
                textBox1.Text = z.ToString() + "  &&  " + s.ToString();
            }
        
    }

        private void button5_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox3.Text);
            double c = Convert.ToDouble(textBox2.Text);
            if (m == 0)
            {
                s = Math.Cos(c);
                textBox1.Text = s.ToString();
            }
            else if (c == 0)
            {
                s = Math.Cos(m);
                textBox1.Text = s.ToString();
            }
            else
            {
                s = Math.Cos(c);
                z = Math.Cos(m);
                textBox1.Text = z.ToString() + "  &&  " + s.ToString();
            }
        
    }

        private void button18_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + "1";


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + "2";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + "8";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + "9";
        }

        private void button20_Click(object sender, EventArgs e)
        {
          
            textBox3.Text = textBox3.Text + ".";
            

        }
    }
}
