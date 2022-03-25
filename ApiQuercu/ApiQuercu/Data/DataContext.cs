using Microsoft.EntityFrameworkCore;
using ApiQuercu.Models;

namespace ApiQuercu.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> option) : base(option) {
        }

        public DbSet<Owner> owners{ get;set; }
        public DbSet<Property> properties { get;set; }
        public DbSet<PropertyType> propertyTypes { get;set; }


    }
}
