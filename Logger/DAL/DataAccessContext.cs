using Logger.Models;
using Microsoft.EntityFrameworkCore;


namespace Logger.DAL
{
    public class DataAccessContext : DbContext
    {
        public DataAccessContext() { }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=MicrocontrollerDB;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ValuesModel>().ToTable("ValuesModels");
        }
        public DbSet<ValuesModel> ValuesModels { get; set; }
    }
}
