﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_minimize_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].WindowState = FormWindowState.Minimized;
        }
    }
}
