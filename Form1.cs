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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            label1.Text = DateTime.Now.ToShortTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Triangle
           Triangle = new Triangle();
            Triangle.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            circle
                circle = new circle();
            circle.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quadrilateral
                Quadrilateral = new Quadrilateral();
            Quadrilateral.Show();
                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CUBE
                CUBE = new CUBE();
            CUBE.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sphere
               Sphere = new Sphere();
            Sphere.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Cylinder
                Cylinder = new Cylinder();
            Cylinder.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cuboid
                Cuboid = new Cuboid();
            Cuboid.Show();
        }
    }
}
