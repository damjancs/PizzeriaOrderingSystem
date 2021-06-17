using PizzaOrderingSystemLibrary.DataAccess;
using PizzaOrderingSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PizzaOrderingSystemLibrary
{
    public  class OrderHelper
    {
        public static void AddOrderItemToBasket(List<OrderItemModel> orderedItemList, ListBox dishesListBox, ListBox additionListBox,
            TextBox priceTextBox, NumericUpDown numericUpDown)
        {
            OrderItemModel oi = new()
            {
                DishName = dishesListBox.GetItemText(dishesListBox.SelectedItem),
                ItemPrice = Convert.ToDecimal(priceTextBox.Text),
                DishAdditions = ConvertAdditionListBoxToString(additionListBox),
                Quantity = (int)numericUpDown.Value
            };
            orderedItemList.Add(oi);
        }

        public static void RemoveOrderItemFromBasket(List<OrderItemModel> orderedItemList, ListBox orderedItemsListBox)
        {
            if (orderedItemList != null)
            {
                orderedItemList.Remove((OrderItemModel)orderedItemsListBox.SelectedItem);
                UpdateBasket(orderedItemsListBox, orderedItemList);
            }
        }

        public static void UpdateListBoxes(ComboBox comboBox, ListBox dishListBox, ListBox additionListBox)
        {
            List<DishModel> dishByCategory = SqlConnector.GetDishesByCategory(comboBox);
            dishListBox.DataSource = dishByCategory;
            dishListBox.DisplayMember = nameof(DishModel.Name);

            List<DishAdditionModel> dishAdditionByCategory = SqlConnector.GetAdditionsByCategory(comboBox);
            additionListBox.DataSource = dishAdditionByCategory;
            additionListBox.DisplayMember = nameof(DishAdditionModel.Name);
            additionListBox.ClearSelected();
        }

        public static void UpdateBasket(ListBox listBox, List<OrderItemModel> orderedItemsList)
        {
            listBox.DataSource = null;
            listBox.DataSource = orderedItemsList;
            listBox.DisplayMember = nameof(OrderItemModel.OrderItemInfo);
        }

        public static void UpdateBasket(ListBox orderedItemsListBox, List<OrderItemModel> orderedItemsList,
            ListBox additionListBox, NumericUpDown numericUpDown)
        {
            orderedItemsListBox.DataSource = null;
            orderedItemsListBox.DataSource = orderedItemsList;
            orderedItemsListBox.DisplayMember = nameof(OrderItemModel.OrderItemInfo);
            ResetOrderGroupBox(additionListBox, numericUpDown);
        }

        public static void CalculateOrderItemPrice(ListBox dishListBox, ListBox additionListBox,
            NumericUpDown numericUpDown, TextBox priceTextBox)
        {
            DishModel d = (DishModel)dishListBox.SelectedItem;
            List<DishAdditionModel> da = additionListBox.SelectedItems.Cast<DishAdditionModel>().ToList();

            decimal additionsPrice = 0;
            foreach (var addition in da)
            {
                additionsPrice += addition.Price;
            }

            decimal orderItemPrice = (d.Price + additionsPrice) * numericUpDown.Value;

            priceTextBox.Text = $"{orderItemPrice:F2}";
        }

        public static void CalculateTotalPrice(List<OrderItemModel> orderedItemsList, TextBox totalPriceTextBox)
        {
            decimal totalPrice = orderedItemsList.Sum(x => x.ItemPrice);

            totalPriceTextBox.Text = $"{totalPrice:F2}";
        }

        public static void ResetOrderGroupBox(ListBox additionListBox, NumericUpDown numericUpDown)
        {
            additionListBox.SelectedIndex = -1;
            numericUpDown.Value = 1;
        }

        public static string ConvertAdditionListBoxToString(ListBox additionListBox)
        {
            List<DishAdditionModel> dishAdditions = additionListBox.SelectedItems.Cast<DishAdditionModel>().ToList();
            StringBuilder sb = new();
            foreach (var addition in dishAdditions)
            {
                sb.Append($"{addition.Name} ");
            }

            return sb.ToString();
        }

        public static string ConvertOrderedItemsListToString(List<OrderItemModel> orderedItems)
        {
            StringBuilder sb = new();
            foreach (var orderedItem in orderedItems)
            {
                sb.Append($"{orderedItem.DishName} ");
            }

            return sb.ToString();
        }
    }
}
