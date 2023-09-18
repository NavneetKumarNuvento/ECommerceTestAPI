using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceTestAPI.Model
{
    public class Product
    {
        public Product()
        {
            this.Attributes = new HashSet<Attributes>();
        }

        [Key]
        public int PK_Product { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
              
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public virtual ICollection<Attributes> Attributes { get; set; }

    }
}
