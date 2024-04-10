using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StopWatch
{
    
    public partial class Stopwatch : Form
    {

        DateTime a, b = DateTime.Now;
        TimeSpan c;

        public Stopwatch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = DateTime.Now;
            textBox1.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {   b = DateTime.Now;
            textBox2.Text = b.ToString();
            c = b - a;
            textBox3.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
