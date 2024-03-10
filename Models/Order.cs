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

        public Order()
        {

        }

        public Order(OrderDTO order)
        {
            this.CreationDate = DateTime.Now;
            this.DueDate = order.DueDate;
            this.Items = new List<Item>();
            this.ClientId = order.ClientId;
        }
    }
}
