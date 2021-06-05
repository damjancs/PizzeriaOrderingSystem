using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingSystemLibrary.Models
{
    public class OrderItemModel
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string DishName { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public string DishAdditions { get; set; }

        public string OrderItemInfo 
        {
            get
            {
                return $"{DishName}, Quantity: {Quantity}, Cost: {ItemPrice}";
            }
        }

    }
}
