﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Ordering_System.GUI
{
    public partial class outputFormGUI : Form
    {
        public outputFormGUI()
        {
            InitializeComponent();
        }
        public outputFormGUI(string msg)
        {
            InitializeComponent();
            lb_msg.Text = msg;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
