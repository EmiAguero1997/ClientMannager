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
        public ICollection<Order>? Orders { get; set; }

        public Client()
        {
            
        }

        public Client(ClientCreateDTO client)
        {
            this.CompanyName = client.CompanyName;
            this.CellPhone = client.CellPhone;
            this.FirstName = client.FirstName;
            this.LastName = client.LastName;
            this.Email = client.Email;
        }
    }
}