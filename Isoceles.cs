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
    public partial class Isoceles : Form
    {
        public Isoceles()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Isoceles_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button3.Visible = false;
            textBox1.Visible = false;
            button2.Visible = false;
            textBox2.Visible = false;
           
        }





        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                if (textBox1.Text == "")
                { }
                else
                {
                    double a, b, c = 3, f;

                    a = float.Parse(textBox1.Text);

                    b = Math.Sqrt(c) / 4;
                    f = (a * a) * b;
                    textBox2.Text = +f + "";
                }
            }
            else if (radioButton2.Checked == true)
            { 
            
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            button3.Visible = true;
            button1.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button2.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            button3.Visible = false;
            button1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button2.Visible = true;
        }
    }
}
