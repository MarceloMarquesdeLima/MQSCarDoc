using MQSCarDoc.Models;
using System.Data.Entity.ModelConfiguration;

namespace MQSCarDoc.DAL.Configuration
{
    public class EmpresaConfiguration : EntityTypeConfiguration<Empresa>
    {
        public EmpresaConfiguration()
        {
            HasKey(c => c.ID);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Ativo)
                .IsRequired();

        }
    }
}
