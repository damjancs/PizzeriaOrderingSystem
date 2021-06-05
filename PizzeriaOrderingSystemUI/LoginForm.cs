﻿using PizzaOrderingSystemLibrary.DataAccess;
using PizzaOrderingSystemLibrary.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaOrderingSystemLibrary;
using PizzaOrderingSystemLibrary.Exceptions;

namespace PizzeriaOrderingSystemUI
{
    public partial class LoginForm : Form
    {
        public string Username { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserValidator.ValidateLoginProcess(usernameTextBox, passwordTextBox))
                {
                    SqlConnector.AuthorizeUser(usernameTextBox.Text, passwordTextBox.Text);
                    Username = usernameTextBox.Text;
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerLabel_Click_1(object sender, EventArgs e)
        {
            RegisterUserForm registerUser = new RegisterUserForm();
            registerUser.ShowDialog();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
