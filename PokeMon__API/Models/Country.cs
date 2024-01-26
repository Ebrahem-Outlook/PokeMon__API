using System.ComponentModel.DataAnnotations;

namespace PokeMon__API.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String? Name { get; set; }
    }
}
