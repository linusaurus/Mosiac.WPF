using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Weaselware.Mosiac.Model
{
    public class OrderReciept
    {
        public OrderReciept()
        {
            this.Inventories = new HashSet<Inventory>();
        }

        public int OrderReceiptID { get; set; }
        public int? EmployeeID { get; set; }
        public int? OrderNum { get; set; }
        public DateTime? ReceiptDate { get; set; }

        public ICollection<Inventory> Inventories { get; set; }
    }
}
