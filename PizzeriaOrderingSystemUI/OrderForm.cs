using PizzaOrderingSystemLibrary;
using PizzaOrderingSystemLibrary.DataAccess;
using PizzaOrderingSystemLibrary.Helpers;
using PizzaOrderingSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PizzeriaOrderingSystemUI
{
    public partial class OrderForm : Form
    {
        private List<OrderItemModel> _orderedItems = new();
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
            try
            {
                var order = SqlConnector.AddOrder(_user, _orderedItems, totalPriceTextBox, noteTextBox);
                var body = EmailSender.CreateEmailBody(_user, order);
                EmailSender.SendEmail(body, _user.Email);
                MessageBox.Show("Order Completed. Thank You!");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("You don't have any items in your basket.");
            }
        }
    }
}
