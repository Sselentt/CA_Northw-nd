namespace CA_Northwınd.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitStock { get; set; }

        //bir ürünün bir category'si vardır
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        //Bir ürünün bir tedarikçisi olur
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }

        //sipariş detay
        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}
