using System.ComponentModel.DataAnnotations;

namespace PokeMon__API.Models
{
    public class Reviewer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String? FirstName { get; set; }

        [Required]
        public String? LastName { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}
