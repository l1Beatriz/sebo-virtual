using Microsoft.EntityFrameworkCore;
using SeboDigital.Models;

namespace SeboDigital.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Evaluation> Evaluations { get; set; }
    public DbSet<Exchange> Exchanges { get; set; }
}