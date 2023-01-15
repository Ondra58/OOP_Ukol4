﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tahac tahoun;
        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0 && numericUpDown2.Value != 0)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                tahoun = new Tahac((string)textBox1.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value);
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Chyba");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown4.Value != 0)
            {
                tahoun.NalozNaklad(((int)numericUpDown4.Value));
            }
            else
            {
                MessageBox.Show("Chyba");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (numericUpDown3.Value != 0)
            {
                tahoun.VylozNaklad((int)numericUpDown3.Value);
            }
            else
            {
                MessageBox.Show("Chyba");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(tahoun.ToString());
            }
            catch
            {
                MessageBox.Show("Chyba");
            }
        }
    }
}
