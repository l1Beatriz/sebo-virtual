using Microsoft.EntityFrameworkCore;

namespace SeboDigital.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
    }
}
