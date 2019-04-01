using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AREA
{
    public partial class Right_angled_triangle : Form
    {
        public Right_angled_triangle()
        {
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float h, b, H;
            h = float.Parse(textBox2.Text);
            b = float.Parse(textBox3.Text);
            H = float.Parse(textBox3.Text);

            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "" || textBox2.Text == "")
            {
               
                label1.Visible = true;
                textBox3.Text = "";
            }
            else
            {
                float h, b, a;
                b = float.Parse(textBox1.Text);
                h = float.Parse(textBox2.Text);
               

                a = (b * h) / 2;
                textBox3.Text = +a + "";
                label1.Visible = false;
            }
            
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
           
            label1.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = false;
            button2.Visible = true;

        }

        private void Right_angled_triangle_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (textBox3.Text == "" || textBox2.Text == "")
                {
                   
                    label1.Visible = true;
                    textBox1.Text = "";
                }
                else
                {
                    double n, g, h, k;
                    n= double.Parse(textBox3.Text);
                    g = double.Parse(textBox2.Text);

                    h = (n * n) - (g * g);
                    k = Math.Sqrt(h);

                    textBox1.Text = +k+ "";
                    label1.Visible = false;
                }
            }
            else if (radioButton2.Checked == true)
            {
                
                if (textBox3.Text == "" || textBox2.Text == "")
                {
                  
                    label1.Visible = true;
                    textBox1.Text = "";
                }
                else
                {
                    float h, b, a;
                    a = float.Parse(textBox3.Text);
                    h = float.Parse(textBox2.Text);

                    b = (2 * a)/h;
                    
                    textBox1.Text = +b + "";
                    label1.Visible = false;
                }
            

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (textBox3.Text == "" || textBox1.Text == "")
                {
                    
                    label1.Visible = true;
                    textBox2.Text = "";
                }
                else
                {
                    double a, b, c,d;
                    a = double.Parse(textBox3.Text);
                    b = double.Parse(textBox1.Text);

                    d = (a * a) - (b * b);
                    c = Math.Sqrt(d);
                    textBox2.Text = +c + "";
                    label1.Visible = false;
                }
            }
            else if (radioButton2.Checked == true)
            {

                if (textBox3.Text == "" || textBox1.Text == "")
                {
                    
                    label1.Visible = true;
                    textBox2.Text = "";
                }
                else
                {
                    float h, b, a;
                    a = float.Parse(textBox3.Text);
                    b = float.Parse(textBox1.Text);

                    h = (2 * a) / b;

                    textBox2.Text = +h + "";
                    label1.Visible = false;
                }


            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           if(textBox1.Text==""||textBox2.Text=="")
            {
                textBox3.Text = "";
            }
           
            {
            double d,m,b,c;
            m = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c=(m*m)+(b*b);
            d = Math.Sqrt(c);
            textBox3.Text = +d + "";
            }
            
            }
        }
    }

