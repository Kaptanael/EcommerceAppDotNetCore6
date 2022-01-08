using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain
{
    public class ProductCategory:BaseEntity
    {
        [Required, StringLength(128)]
        public string Name { get; set; }

        [StringLength(256)]
        public string Description { get; set; }
    }
}
