using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ögrenci_kayit_Formu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = textBox1.Text;
            label7.Text = textBox2.Text;
            label9.Text = textBox3.Text;
            label11.Text = textBox4.Text;
            label14.Text = textBox5.Text;
            label17.Text = textBox6.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
