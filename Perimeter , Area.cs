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
    public partial class Perimeter___Area : Form
    {
        public Perimeter___Area()

        {

            InitializeComponent();
        }

        public void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            { }
            else
            {
                float a, b, c, s;
                a = float.Parse(textBox1.Text);
                b = float.Parse(textBox2.Text);
                c = float.Parse(textBox3.Text);
                s = a + b + c;
                textBox4.Text = +s + "";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
      
        }

        private void Perimeter___Area_Load(object sender, EventArgs e)
        {
            button6.Visible = false;
            button5.Visible = false;
            textBox4.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            { }
            else
            {
                float a, b, c, s;
                double f, d;
                a = float.Parse(textBox1.Text);
                b = float.Parse(textBox2.Text);
                c = float.Parse(textBox3.Text);
                s = (a + b + c) / 2;
                f = s * ((s - a) * (s - b) *(s - c));
                d = Math.Sqrt(f);
                textBox4.Text = +d + "";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            button6.Visible = false;
            textBox4.Visible = true;
            button5.Visible = true;
        
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            button5.Visible = false;
            textBox4.Visible = true;
            button6.Visible = true;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
