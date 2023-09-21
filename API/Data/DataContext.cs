using Microsoft.EntityFrameworkCore;
using API.Entities;
// like views in django
// using kaip importai
// namespace tai tas pats kas klasiu pav 
// tai jei noresiu kviesti DataContext.cs 
// fila man reiktu 
// kitam faile rasyti using API.Data;


namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppUser> Users{get; set;}
}
