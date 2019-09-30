using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }
        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }


        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }
        double acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double force,angle;

            try
            {
                force = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show(textBox2.Text + "  ,does this look like numbers");
                force = 0;
                
            }

            try
            {
                angle = double.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show(textBox3.Text + " ,does this look like numbers" );
                angle = 0;
            }
            
            

            double Fx = force * cos(angle);
            label2.Text = "Fx =" + Fx;

            double Fy = force * sin(angle);
            label1.Text = "Fy =" + Fy;

        }
    }
}