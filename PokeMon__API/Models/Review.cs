using System.ComponentModel.DataAnnotations;

namespace PokeMon__API.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String? Title { get; set; }

        [Required]
        public String? Text { get; set; }
    }
}
