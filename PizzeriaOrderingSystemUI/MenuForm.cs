using PizzaOrderingSystemLibrary.DataAccess;
using PizzaOrderingSystemLibrary.Models;
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
    public partial class MenuForm : Form
    {
        private UserModel _user = new();

        public object HistoryForm { get; private set; }

        public MenuForm()
        {
            InitializeComponent();

            this.Hide();

            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                _user = SqlConnector.GetUser(loginForm.Username);
                this.Show();
                helloLabel.Text = $"Hello {_user.Username}! Feel free to order some dish.";
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(_user);
            orderForm.ShowDialog();
        }

        private void orderHistoryButton_Click(object sender, EventArgs e)
        {
            OrderHistoryForm orderHistoryForm = new OrderHistoryForm(_user);
            orderHistoryForm.ShowDialog();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
