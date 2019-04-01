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
    public partial class CUBE : Form
    {
        public CUBE()
        {
            InitializeComponent();
        }

        private void CUBE_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox2.Visible = false;
            
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = false;
            textBox2.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = true;
            textBox2.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { }
            else
            {
                float a, p;
                a = float.Parse(textBox1.Text);
                p = 12 * a;
                textBox2.Text = "" + p;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { }
            else
            {
                float s, p;
                s = float.Parse(textBox1.Text);
                p = 6 * (s*s);
                textBox2.Text = "" + p;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { }
            else
            {
                float s, p;
                s = float.Parse(textBox1.Text);
                p = s*s*s;
                textBox2.Text = "" + p;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            CubeTeminology
                CubeTeminology = new CubeTeminology();
            CubeTeminology.Show();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            textBox2.Visible = true;
        }
    }
}
