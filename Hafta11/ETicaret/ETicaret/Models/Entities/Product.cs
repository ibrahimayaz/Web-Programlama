using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETicaret.Models.Entities
{
    //Domain=Entity=Varlık=Model

    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; } = string.Empty;

        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public Product()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
