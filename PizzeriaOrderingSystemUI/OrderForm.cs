using PizzaOrderingSystemLibrary;
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
    public partial class OrderForm : Form
    {
        private List<OrderItemModel> _orderedItems = new List<OrderItemModel>();
        private UserModel _user;

        public OrderForm(UserModel user)
        {
            InitializeComponent();
            _user = user;
            categoryComboBox.SelectedIndex = 0;
        }


        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderHelper.UpdateListBoxes(categoryComboBox, dishesListBox, additionListBox);
        }

        private void dishesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderHelper.CalculateOrderItemPrice(dishesListBox, additionListBox, numericUpDown, priceTextBox);
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            OrderHelper.CalculateOrderItemPrice(dishesListBox, additionListBox, numericUpDown, priceTextBox);
        }

        private void additionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderHelper.CalculateOrderItemPrice(dishesListBox, additionListBox, numericUpDown, priceTextBox);
        }

        private void addToBasketLabel_Click(object sender, EventArgs e)
        {
            OrderHelper.AddOrderItemToBasket(_orderedItems, dishesListBox,
                additionListBox, priceTextBox, numericUpDown);
            OrderHelper.CalculateTotalPrice(_orderedItems, totalPriceTextBox);
            OrderHelper.UpdateBasket(orderedItemsListBox, _orderedItems, additionListBox, numericUpDown);
        }

        private void removeSelectedButton_Click(object sender, EventArgs e)
        {
            OrderHelper.RemoveOrderItemFromBasket(_orderedItems, orderedItemsListBox);
            OrderHelper.CalculateTotalPrice(_orderedItems, totalPriceTextBox);
            OrderHelper.UpdateBasket(orderedItemsListBox, _orderedItems);
        }

        private void completeOrderButton_Click(object sender, EventArgs e)
        {
            SqlConnector.AddOrder(_user, _orderedItems, totalPriceTextBox, noteTextBox);
            MessageBox.Show("Order Completed. Thank You!");
            this.Close();
        }
    }
}
