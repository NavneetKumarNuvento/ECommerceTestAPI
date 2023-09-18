using ECommerceTestAPI.Model;
using System.ComponentModel.DataAnnotations;

namespace ECommerceTestAPI.ModelsDTO
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public ICollection<AttributesDTO> Attributes { get; set; }

    }
}
