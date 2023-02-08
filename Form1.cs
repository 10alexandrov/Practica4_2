using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practica4_3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // textOne = textBox1.Text;
            textBox2.Text = "";
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           // textOne = textBox2.Text;
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 2*int.Parse(textBox1.Text);
            textBox3.Text = a.ToString();
            a = a / 4;
            textBox4.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a = 2 * float.Parse(textBox2.Text);
            textBox3.Text = a.ToString();
            a = a / 4;
            textBox4.Text = a.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
