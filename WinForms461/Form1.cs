﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms461
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Assembly.GetExecutingAssembly().ImageRuntimeVersion;
            label2.Text = this.FormBorderStyle.GetType().Assembly.Location;
            label3.Text = Assembly.GetExecutingAssembly().Location;
        }
    }
}
