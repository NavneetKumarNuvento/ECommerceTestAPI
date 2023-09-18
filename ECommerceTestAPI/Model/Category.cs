using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceTestAPI.Model
{
    public class Category
    {
        [Key]
        public int PK_CatId { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }

    }
}
