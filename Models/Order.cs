namespace ClientMannager.Models
{
    public class Order
    {
        public long Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DueDate { get; set; }
        public Client Client { get; set; }
        public long ClientId { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
