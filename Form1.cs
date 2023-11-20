using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ilkFiyat = Convert.ToDouble(textBox1.Text);
            double yeniFiyat;
            yeniFiyat = ilkFiyat * 1.25;
            label3.Text = yeniFiyat.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ilkFiyat = Convert.ToDouble(textBox1.Text);
            double yeniFiyat;
            yeniFiyat = ilkFiyat * 1.50;
            label3.Text = yeniFiyat.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double ilkFiyat = Convert.ToDouble(textBox1.Text);
            double yeniFiyat;
            yeniFiyat = ilkFiyat * 0.75;
            label3.Text = yeniFiyat.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double ilkFiyat = Convert.ToDouble(textBox1.Text);
            double yeniFiyat;
            yeniFiyat = ilkFiyat * 0.50;
            label3.Text = yeniFiyat.ToString();
        }
    }
}
