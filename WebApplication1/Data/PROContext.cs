
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
namespace WebApplication1.Data
{
    public class PROContext : DbContext
    {
        public PROContext(DbContextOptions<PROContext> options) : base(options)
        {

        }
        public DbSet<Student> Students{get;set;}
        public DbSet<Department> Department {get; set;}
    }
}
