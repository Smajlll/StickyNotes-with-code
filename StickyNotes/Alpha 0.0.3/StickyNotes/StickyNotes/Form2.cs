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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 OpenOS = new Form1();
            OpenOS.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);


        }
    }
}
