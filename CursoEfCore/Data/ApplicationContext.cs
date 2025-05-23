using CursoEfCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CursoEfCore.Data
{
    public class ApplicationContext : DbContext

    {

        public DbSet<Pedido> Pedidos { get; set; } // -> Inclusão no modelo de dados

        //pelo parametro abaixo informa o Provider Sql Server
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Initial Catalog=CursoEFCore;Integrated Security=true");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
                aqui se pode aplicar cada configuração em separado, mas a forma abaixo faz o EF procurar por todas as classes
                que foram implementadas via IEntityTypeConfiguration
            */

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);



        }
                
               
        }

    }

