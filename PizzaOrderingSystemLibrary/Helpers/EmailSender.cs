using PizzaOrderingSystemLibrary.DataAccess;
using PizzaOrderingSystemLibrary.Models;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace PizzaOrderingSystemLibrary.Helpers
{
    public class EmailSender
    {
        public static string CreateEmailBody(UserModel user, OrderModel order)
        {
            var orderItems = SqlConnector.GetOrderItemsById(order);

            var body = new StringBuilder();
            body.AppendLine($"Hello {user.Firstname}!");
            body.AppendLine($"You ordered: ");

            foreach (var orderItem in orderItems)
            {
                body.AppendLine($"Name: {orderItem.DishName}, Price: {orderItem.ItemPrice} zł, Quantity: {orderItem.Quantity}");
                body.AppendLine($"Additions: {orderItem.DishAdditions}");
                body.AppendLine("____________________________________________________________");
            }

            body.AppendLine($"Total price: {order.TotalPrice} zł");
            body.AppendLine($"Order date: {order.OrderDate}");

            return body.ToString();
        }

        public static void SendEmail(string body, string userEmail)
        {
            try
            {
                MailMessage message = new();
                SmtpClient smtpClient = new();
                message.From = new MailAddress("damians.emailsender@gmail.com");
                message.To.Add(new MailAddress(userEmail));
                message.Subject = "PizzeriaOrderingSystem - order information";
                message.Body = body;
                smtpClient.Port = 587;
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("", "");
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Send(message);
            }
            catch (Exception) { }
        }
    }
}
