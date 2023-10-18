using System.ComponentModel.DataAnnotations;

namespace CS01EFC.Models
{
    internal class Genre
    {
        public int GenreId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<Movie>? Movies { get; set; }
    }
}
