namespace CA_Northwınd.Entities
{
    public class Employees
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        //bir çalışanın bir çok satış yapabilir.
        public virtual List<Order> Orders { get; set; }

    }
}
