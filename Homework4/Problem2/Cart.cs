using System.Collections.Generic;

namespace HW4EX2B4.TightCoupling.Model
{https://github.com/fpeclique/AdvCSharp
    public class Cart
    {
        public decimal TotalAmount { get; set; }
        public IEnumerable<OrderItem> Items { get; set; }
        public string CustomerEmail { get; set; }

        public Cart()
        {
            Items = new List<OrderItem>();
        }
    }
}
