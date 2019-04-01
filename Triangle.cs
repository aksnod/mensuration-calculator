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
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tentero
                Tentero = new Tentero();
            Tentero.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Tproperties
                Tproperties = new Tproperties();
            Tproperties.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Right_angled_triangle
                Right_angled_triangle = new Right_angled_triangle();
            Right_angled_triangle.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Perimeter___Area
                Perimeter___Area = new Perimeter___Area();
            Perimeter___Area.Show();
            
                
        }

        private void button3_Click(object sender, EventArgs e)
        {

                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Isoceles
    Isoceles = new Isoceles();
            Isoceles.Show();
        }
    }
}
