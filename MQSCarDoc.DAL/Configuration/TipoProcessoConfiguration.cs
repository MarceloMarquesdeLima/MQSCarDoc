using MQSCarDoc.Models;
using System.Data.Entity.ModelConfiguration;

namespace MQSCarDoc.DAL.Configuration
{
    public class TipoProcessoConfiguration : EntityTypeConfiguration<TipoProcesso>
    {
        public TipoProcessoConfiguration()
        {
            HasKey(c => c.ID);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
