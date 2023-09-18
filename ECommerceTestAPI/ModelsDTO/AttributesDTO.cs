using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

namespace ECommerceTestAPI.ModelsDTO
{
    public class AttributesDTO
    {
        public string Name { get; set; }
        public string Values { get; set; }
    }
}
