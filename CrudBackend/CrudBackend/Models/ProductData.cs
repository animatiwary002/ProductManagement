using System.ComponentModel.DataAnnotations;

namespace CrudBackend.Models
{
    public class ProductData
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

    }
}
