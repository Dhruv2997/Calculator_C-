using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPractical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            float t1 = Convert.ToSingle(textBox1.Text);
            float t2 = Convert.ToSingle(textBox2.Text);

            float result = t1 + t2;

            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float t1 = Convert.ToSingle(textBox1.Text);
            float t2 = Convert.ToSingle(textBox2.Text);

            float result = t1 - t2;

            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float t1 = Convert.ToSingle(textBox1.Text);
            float t2 = Convert.ToSingle(textBox2.Text);

            float result = t1 * t2;

            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float t1 = Convert.ToSingle(textBox1.Text);
            float t2 = Convert.ToSingle(textBox2.Text);

            float result = t1 / t2;

            textBox3.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float t1 = Convert.ToSingle(textBox1.Text);
            float t2 = Convert.ToSingle(textBox2.Text);
            double result = 1;

            while (t2 != 0)
            {
                result *= t1;
                --t2;
            }
            

            textBox3.Text = result.ToString();
        }
    }
}
