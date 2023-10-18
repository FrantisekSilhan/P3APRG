using CS02SQLite.Data;
using Microsoft.EntityFrameworkCore;

AppDbContext db = new AppDbContext(@"Data Source=myGamesDatabase.db");

foreach (var c in db.Companies.ToList())
{
    Console.WriteLine(c.Name);
}

foreach (var g in db.Games.Include(g => g.Developments).ThenInclude(d => d.Company).ToList())
{
    Console.WriteLine(g.Name);
    foreach (var c in g.Developments)
    {
        Console.WriteLine(" " + c.Company.Name);
    }
}