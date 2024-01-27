using System.ComponentModel.DataAnnotations;

namespace PokeMon__API.Models
{
    public class Owner
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String? Name { get; set; }

        [Required]
        public String? Gym { get; set; }

        public Country Country { get; set; }
    }
}
