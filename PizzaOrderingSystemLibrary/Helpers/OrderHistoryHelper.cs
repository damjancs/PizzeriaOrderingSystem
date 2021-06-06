using PizzaOrderingSystemLibrary.DataAccess;
using PizzaOrderingSystemLibrary.Models;
using System.Collections;
using System.Windows.Forms;

namespace PizzaOrderingSystemLibrary.Helpers
{
    public class OrderHistoryHelper
    {
        public static void CreateDataGrid(UserModel user, DataGridView orderHistoryDataViewGrid)
        {
            var orders = SqlConnector.GetOrderByUserId(user);

            orderHistoryDataViewGrid.ColumnCount = 3;
            orderHistoryDataViewGrid.Columns[0].Name = "Order Id";
            orderHistoryDataViewGrid.Columns[1].Name = "Price";
            orderHistoryDataViewGrid.Columns[2].Name = "Order Date";

            foreach (var order in orders)
            {
                ArrayList row = new ArrayList();
                row.Add($"{order.Id}");
                row.Add($"{order.TotalPrice} zł");
                row.Add($"{order.OrderDate.ToString("dddd, dd MMMM yyyy")}");
                orderHistoryDataViewGrid.Rows.Add(row.ToArray());
            }



        }
    }
}
