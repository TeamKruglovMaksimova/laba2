﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
         private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Война и мир";
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Лев Толстой";
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2013 год";
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Азбука";
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1504";
        }
    }
}