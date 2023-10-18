using CS01EFC.Data;
using CS01EFC.Models;
using Microsoft.EntityFrameworkCore;

var db = new AppDbContext();
// Add-Migration Initial
// Update-Database

IList<Movie> movies1 = db.Movies.ToList();
foreach (Movie movie in movies1)
{
    Console.WriteLine(movie.Name);
}


Console.WriteLine();

IList<Movie> movies2 = db.Movies.Where(x => x.Name.Contains("piece")).ToList();
foreach (Movie movie in movies2)
{
    Console.WriteLine(movie.Name);
}


Console.WriteLine();

IList<Movie> movies3 = db.Movies.Include(x => x.Genre).ToList();
foreach (Movie movie in movies3)
{
    Console.WriteLine(string.Format("{0} {1}", movie.Name, movie.Genre!.Name));
}


Console.WriteLine();

Movie? mov = db.Movies.Where(x => x.MovieId == 1).SingleOrDefault();
db.Entry(mov).Reference(x => x.Genre);
if (mov != null)
{
    Console.WriteLine(string.Format("{0} {1}", mov.Name, mov.Genre.Name));
}


Console.WriteLine();

Genre? g = db.Genres.Where(x => x.GenreId == 1).SingleOrDefault();
db.Entry(g).Collection(x => x.Movies);
if (g != null)
{
    Console.WriteLine(g.Name);
    foreach (Movie movie in g.Movies)
    {
        Console.WriteLine(movie.Name);
    }
}

/*Console.WriteLine("Movie name: ");
string newName = Console.ReadLine();
db.Movies.Add(new Movie { Name = newName, GenreId = 1 });

Console.WriteLine("Saving...");
try
{
    db.SaveChanges();
    Console.WriteLine("Done");
}
catch (Exception ex)
{
    Console.WriteLine(string.Format("Error: {0}", ex));
}*/