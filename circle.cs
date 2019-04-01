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
    public partial class circle : Form
    {
        public circle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Definations
            Definations = new Definations();
            Definations.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button4.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = "";
            textBox1.Text = "";
            button5.Visible = false;
        }

        private void circle_Load(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            textBox2.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button4.Visible = false;
            textBox2.Visible = true;
            textBox2.Text = "";
            textBox1.Text = "";
            button5.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            { }
            else
            {
                float p, r;
                float pi = 22 ;
                r =float.Parse(textBox1.Text);
                p = (44 * r) / 7;
                textBox2.Text = "" + p;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { }
            else
            {
                float p, r;
                float pi = 22;
                r = float.Parse(textBox1.Text);
                p = (22 * r*r) / 7;
                textBox2.Text = "" + p;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
