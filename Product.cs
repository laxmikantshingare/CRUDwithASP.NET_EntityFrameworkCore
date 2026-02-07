using System.ComponentModel.DataAnnotations;

namespace CRUDAspNetEFCore.Model
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Price { get; set; }
    }
}
