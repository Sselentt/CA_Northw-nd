namespace CA_Northwınd.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public string? ShipName { get; set; }


        //müşteri
        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }


        //çalışan
        public int? EmployeeId { get; set; }
        public virtual Employees Employees { get; set; }


        //Nakliye
        public int? ShipVia { get; set; }
        public virtual Shipper Shipper { get; set; }

        //sipariş detay
        public virtual OrderDetail OrderDetail { get; set; }

    }
}
