using Microsoft.Data.SqlClient;
using PizzaOrderingSystemLibrary.DataAccess;
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

namespace PizzeriaOrderingSystemUI
{
    public partial class RegisterUserForm : Form
    {
        public RegisterUserForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserValidator.ValidateRegistrationProcess(
                    userNameTextBox,
                    PasswordTextBox,
                    firstNameTextBox,
                    lastNameTextBox,
                    emailTextBox,
                    addressTextBox,
                    phoneTextBox))
                {
                    SqlConnector.AddUser(
                        userNameTextBox.Text,
                        PasswordTextBox.Text,
                        firstNameTextBox.Text,
                        lastNameTextBox.Text,
                        birthDateTimePicker.Value,
                        emailTextBox.Text,
                        addressTextBox.Text,
                        phoneTextBox.Text);

                    MessageBox.Show("Succesfully registered.");
                    this.Close();
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("This username is already taken.", "Error", MessageBoxButtons.OK);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
