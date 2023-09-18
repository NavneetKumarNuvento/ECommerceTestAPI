using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;

namespace ECommerceTestAPI.Model
{
    public class Attributes
    {
        [Key]
        public int Pk_AttrId { get; set; }
        public string Name { get; set; }
        public string Values { get; set; }
    }
}
