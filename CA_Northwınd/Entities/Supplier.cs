namespace CA_Northwınd.Entities
{
    public class Supplier
    {

        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string? Address { get; set; }


        //bir tedarikçini bir çok ürünü olur
        public virtual List<Product> Products { get; set; }


    }
}
