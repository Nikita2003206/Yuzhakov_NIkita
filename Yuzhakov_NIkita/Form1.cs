using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yuzhakov_NIkita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var a = Sum_Zaim.Text;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var b = Srok_Zaim.Text;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Rasschet_Click(object sender, EventArgs e)
        {

            var a = Convert.ToDouble(Sum_Zaim.Text);
            double c = 0;
            c = (a / 100 * 0.25);
            double d = a + c; //  в день

            var b = Convert.ToDouble(Srok_Zaim.Text);
            double t = 0;
            t =(d*b);
            string y = Convert.ToString(t);

            MessageBox.Show(y);
           


        }


        private void Ef_Stavka_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
