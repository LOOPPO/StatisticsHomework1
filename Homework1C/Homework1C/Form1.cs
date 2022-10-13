using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Press to see a string";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            label2.Text = "Well done, that's a string text";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            label2.Text = string.Empty;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
