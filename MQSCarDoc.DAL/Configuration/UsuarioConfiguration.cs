using MQSCarDoc.Models;
using System.Data.Entity.ModelConfiguration;

namespace MQSCarDoc.DAL.Configuration
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            HasKey(c => c.ID);

            Property(c => c.UserName)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.SenhaUser)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
