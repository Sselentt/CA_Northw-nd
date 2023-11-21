namespace CA_Northwınd.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string? Address { get; set; }


        //bir müşterinin bir çok siparişi olur
        public virtual List<Order> Orders { get; set; }

    }

}

