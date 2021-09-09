using Microsoft.EntityFrameworkCore;
using FilmesAPI.Models;


namespace FilmesAPI.Data
{
    public class FilmeContext : DbContext
    {
        public DbSet<Filmes> Filmes { get; set; }

        public FilmeContext(DbContextOptions<FilmeContext> options) : base(options)
        {
        }

    }
}
