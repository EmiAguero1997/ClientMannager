namespace ClientMannager.Models
{
    public class OrderDTO
    {
        public DateTime CreationDate { get; set; }
        public DateTime DueDate { get; set; }
        public long ClientId { get; set; }
    }
}
