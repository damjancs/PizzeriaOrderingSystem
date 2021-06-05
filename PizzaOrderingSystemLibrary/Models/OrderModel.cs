using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingSystemLibrary.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderItems { get; set; }
        public string Note { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual OrderItemModel OrderedItem { get; set; }
    }
}
