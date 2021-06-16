using PizzaOrderingSystemLibrary.Helpers;
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
    public partial class OrderHistoryForm : Form
    {
        private UserModel _user;
        public OrderHistoryForm(UserModel user)
        {
            InitializeComponent();
            _user = user;
        }



        private void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            OrderHistoryHelper.CreateDataGrid(_user, orderHistoryDataGridView);
        }
    }
}
