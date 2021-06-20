﻿using Restaurant_Ordering_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Ordering_System.GUI
{
    public partial class managerGUI : Form
    {
        public managerGUI()
        {
            InitializeComponent();
        }
        public managerGUI(userDTO udto)
        {
            InitializeComponent();
            show_username.Text = udto.Username;
            show_email.Text = udto.Email;
            show_contact.Text = udto.Contact;
            show_salary.Text = udto.Salary;
            show_role.Text = udto.Role;
            show_status.Text = udto.Status;
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            categoryGUI catgui = new categoryGUI();
            catgui.ShowDialog();
        }

        private void btn_fooditem_Click(object sender, EventArgs e)
        {
            foodItemGUI foodgui = new foodItemGUI();
            foodgui.ShowDialog();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            customerGUI cgui = new customerGUI();
            cgui.ShowDialog();
        }
    }
}
