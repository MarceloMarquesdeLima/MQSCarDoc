using MQSCarDoc.Models;
using System.Data.Entity.ModelConfiguration;

namespace MQSCarDoc.DAL.Configuration
{
    public class PermissaoConfiguration : EntityTypeConfiguration<Permissao>
    {
        public PermissaoConfiguration()
        {
            HasKey(c => c.ID);

            Property(c => c.NomePermissao)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
