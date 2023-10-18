using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CS01EFC.Models
{
    internal class Movie
    {
        //public int MovieId { get; set; }

        //[Key]
        //public int KeyToMovie { get; set; }
        public int MovieId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        public int? Duration { get; set; }
        [ForeignKey("GenreId")]
        public Genre? Genre { get; set; }
        public int GenreId { get; set; }
        public ICollection<Artist>? Artists { get; set; }
    }
}
