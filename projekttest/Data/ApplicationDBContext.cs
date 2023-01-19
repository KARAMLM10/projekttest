using Microsoft.EntityFrameworkCore;

namespace projekttest.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Shape> shapes { get; set; }
        public DbSet<Calculator> calculators { get; set; }
        public DbSet<RPSGAME> RPSGAMEs { get; set; }    
        public ApplicationDBContext()
        {
            // en tom konstruktor behövs för att skapa migrations
        }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.;Database=projekttest;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

    }
}