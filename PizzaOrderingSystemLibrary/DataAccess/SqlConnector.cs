using PizzaOrderingSystemLibrary.Helpers;
using PizzaOrderingSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PizzaOrderingSystemLibrary.DataAccess
{
    public class SqlConnector
    {
        public static List<DishModel> GetDishes()
        {
            using var db = new PizzaOrderingSystemDbContext();
            var dishes = db.Dish
                .ToList();

            return dishes;
        }

        public static List<string> GetDishCategories()
        {
            using var db = new PizzaOrderingSystemDbContext();
            var dishes = db.Dish
                .Select(c => c.Category)
                .ToList();

            return dishes;
        }

        public static List<DishModel> GetDishesByCategory(ComboBox comboBox)
        {
            using var db = new PizzaOrderingSystemDbContext();
            var dishes = db.Dish
                .Where(c => c.Category == comboBox.SelectedItem.ToString())
                .ToList();

            return dishes;
        }

        public static List<DishAdditionModel> GetAdditionsByCategory(ComboBox comboBox)
        {
            using var db = new PizzaOrderingSystemDbContext();
            var additions = db.DishAddition
                .Where(c => c.Category == comboBox.SelectedItem.ToString())
                .ToList();

            return additions;
        }

        public static void AddUser(string username, string password, string firstName,
            string lastName, DateTime birthDate, string email, string address,
            string phone)
        {
            using var db = new PizzaOrderingSystemDbContext();
            UserModel newUser = new()
            {
                Username = username,
                PasswordHash = UserHelper.ComputeSHA256Hash(password),
                Firstname = firstName,
                Lastname = lastName,
                BirthDate = birthDate,
                Email = email,
                Address = address,
                Phone = phone
            };
            db.User.Add(newUser);
            db.SaveChanges();
        }

        public static void AuthorizeUser(string username, string password)
        {
            using var db = new PizzaOrderingSystemDbContext();
            var user = db.User.First(u => u.Username == username);

            var passwordCheck = UserHelper.ComputeSHA256Hash(password).Equals(user.PasswordHash);

            if (!passwordCheck)
            {
                throw new Exception();
            }
        }

        public static UserModel GetUser(string username)
        {
            using var db = new PizzaOrderingSystemDbContext();
            var user = db.User.First(u => u.Username == username);

            return user;
        }

        public static OrderModel AddOrder(UserModel user, List<OrderItemModel> orderedItems, TextBox totalPriceTextBox, TextBox noteTextBox)
        {
            using var db = new PizzaOrderingSystemDbContext();
            OrderModel order = new()
            {
                TotalPrice = Convert.ToDecimal(totalPriceTextBox.Text),
                Note = noteTextBox.Text,
                OrderItems = OrderHelper.ConvertOrderedItemsListToString(orderedItems),
                OrderDate = DateTime.Now,
                UserId = user.Id,
            };

            db.Order.Add(order);
            db.SaveChanges();

            foreach (var orderedItem in orderedItems)
            {
                orderedItem.OrderId = order.Id;
                db.OrderItem.Add(orderedItem);
            }

            db.SaveChanges();

            return order;
        }

        public static List<OrderModel> GetOrderByUserId(UserModel user)
        {
            using var db = new PizzaOrderingSystemDbContext();
            var orders = db.Order
                .Where(o => o.UserId == user.Id)
                .ToList();

            return orders;
        }

        public static List<OrderItemModel> GetOrderItemsById(OrderModel order)
        {
            using var db = new PizzaOrderingSystemDbContext();
            var orderItems = db.OrderItem
                .Where(oi => oi.OrderId == order.Id)
                .ToList();

            return orderItems;
        }
    }
}
