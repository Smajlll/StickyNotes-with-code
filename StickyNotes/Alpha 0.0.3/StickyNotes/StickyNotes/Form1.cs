using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 OpenOS = new Form2();
            OpenOS.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutBox1 a1 = new AboutBox1();
            a1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 a1 = new Form1();
            a1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 a1 = new Form3();
            a1.ShowDialog();
        }
    }
}
