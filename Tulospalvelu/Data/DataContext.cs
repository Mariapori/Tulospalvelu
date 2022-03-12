using Microsoft.EntityFrameworkCore;

namespace Tulospalvelu.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Database=tulospalvelu;Uid=tulospalvelu;Pwd=tulospalvelu;";
            optionsBuilder.UseMySql(connectionString, ServerVersion.Parse("10.4.22-MariaDB"));
        }

        public virtual DbSet<Tilasto> Tilastot { get; set; }
        public virtual DbSet<Joukkue> Joukkueet { get; set; }

    }
}
