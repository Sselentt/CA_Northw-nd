using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Northwınd.Entities
{
    public class OrderDetail
    {
        public decimal UnitPrice { get; set; }
        public int Quentity { get; set; }
        public float Discount { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
