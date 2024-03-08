namespace ClientMannager.Models
{
    public class Client
    {
        public long Id { get; set; }
        public string CompanyName { get; set; }
        public string CellPhone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}