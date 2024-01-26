using System.ComponentModel.DataAnnotations;

namespace PokeMon__API.Models
{
    public class Pokemon
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String? Name { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }
    }
}
