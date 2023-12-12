using System.ComponentModel.DataAnnotations;

namespace ETicaret.Models
{
    //Domain=Entity=Varlık=Model

    public class Product
    {
        public int Id { get; set; }

        [Required]
        public String Name { get; set; } = String.Empty;

        public String? Description { get; set; } = String.Empty;

        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public Product()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
