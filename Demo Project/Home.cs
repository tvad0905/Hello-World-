﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var myForm = new ConfigDevices();
            myForm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var myForm = new ConfigFIileLog();
            myForm.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
            DateTime dt = DateTime.Now;
            label1.Text = dt.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            timer1.Start();
        }
    }
}
