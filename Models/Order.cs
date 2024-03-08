namespace ClientMannager.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DueDate { get; set; }
        public Client Client { get; set; }
        public long ClientId { get; set; }
    }
}
