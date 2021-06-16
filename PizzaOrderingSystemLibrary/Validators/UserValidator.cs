using PizzaOrderingSystemLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderingSystemLibrary.Validators
{
    public static class UserValidator
    {
        public static bool ValidateRegistrationProcess(
            TextBox usernameTextBox,
            TextBox passwordTextBox,
            TextBox firstNameTextBox,
            TextBox lastNameTextBox, 
            TextBox emailTextBox,
            TextBox addressTextBox,
            TextBox phoneTextBox)
        {
            string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            string phonePattern = @"\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})";

            bool isPhoneValid = Regex.IsMatch(phoneTextBox.Text, phonePattern);
            bool isEmailValid = Regex.IsMatch(emailTextBox.Text, emailPattern);

            if (usernameTextBox.Text == "" || passwordTextBox.Text == "" || firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || addressTextBox.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }

            if (!isEmailValid)
            {
                MessageBox.Show("Please enter a valid email");
                emailTextBox.Focus();
                return false;
            }

            if (!isPhoneValid)
            {
                MessageBox.Show("Please enter a valid phone number. Correct format is xxx-xxx-xxx");
                phoneTextBox.Focus();
                return false;
            }

            return true;
        }
        public static bool ValidateLoginProcess(TextBox usernameTextBox, TextBox passwordTextBox)
        {
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            return true;
        }
    } 
}


