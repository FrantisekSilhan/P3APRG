using System.ComponentModel.DataAnnotations.Schema;

namespace CS01EFC.Models
{
    internal class ArtistMovie
    {
        [ForeignKey("ArtistId")]
        public Artist Artist { get; set; }
        public int ArtistId { get; set; }
        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
        public string? RoleName { get; set; }
    }
}
