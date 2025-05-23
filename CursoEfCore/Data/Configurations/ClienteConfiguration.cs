
using Microsoft.EntityFrameworkCore;
using CursoEfCore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CursoEfCore.Data.Configurations  // ideia é agrupar classes de configurações
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>     //interface generica que aguarda um tipo de objeto
    {
        // ao informar a linha acima, o programa já sugere a implementação da interface com o metodo abaixo
        public void Configure(EntityTypeBuilder<Cliente> builder) //-> e dentro desse metodo implementa o modelo de dados
        {
            builder.ToTable("Clientes");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(p => p.Telefone).HasColumnType("CHAR(11)");
            builder.Property(p => p.CEP).HasColumnType("CHAR(8)").IsRequired();
            builder.Property(p => p.Estado).HasColumnType("CHAR(2)").IsRequired();
            builder.Property(p => p.Cidade).HasMaxLength(60).IsRequired();

            builder.HasIndex(i => i.Telefone).HasName("idx_cliente_telefone");
        }
    }
}
