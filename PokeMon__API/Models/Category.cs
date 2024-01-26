using System.ComponentModel.DataAnnotations;

namespace PokeMon__API.Models
{
    public class Category
    {
        [Key]
        public int MyProperty { get; set; }

        [Required]
        public String? Name { get; set; }
    }
}
