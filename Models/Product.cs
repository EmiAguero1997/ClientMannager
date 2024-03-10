using ClientMannager.DTOs;

namespace ClientMannager.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public Product()
        {

        }

        public Product(ProductDTO productDTO)
        {
            this.Name = productDTO.Name;
            this.Price = productDTO.Price;
        }
    }
}
