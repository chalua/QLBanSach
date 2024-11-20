﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_QLBS;
using DTO_QLBS;


namespace QLBanSach
{
    public partial class Login : Form
    {
        LoginBLL login = new LoginBLL();
        public Login()
        {
            InitializeComponent();
            this.btn_login.Click += Btn_login_Click;
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            
            if (login.getUserNameAndPassword(txt_username.Text, txt_password.Text))
            {
                Properties.Settings.Default.userName = login.getNameUserName(txt_username.Text, txt_password.Text);
                MessageBox.Show("login sucessful");
                Home home = new Home();
                home.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failure");
            }
        }
    }
}
