namespace CA_Northwınd.Entities
{
    public class Shipper
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int? PhoneNumber { get; set; }

        //bir nakliye birden çok sipariş dağıtır
        public virtual List<Order> Orders { get; set; }

    }
}
