namespace CS02SQLite.Models
{
    internal class Development
    {
        public int DevelopmentId { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
