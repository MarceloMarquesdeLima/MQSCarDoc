using MQSCarDoc.Models;
using System.Data.Entity.ModelConfiguration;

namespace MQSCarDoc.DAL.Configuration
{
    public class PermissaoUsuarioConfiguration : EntityTypeConfiguration<PermissaoUsuario>
    {
        public PermissaoUsuarioConfiguration()
        {
            Property(c => c.PermissaoId)
                .IsRequired();
            Property(c => c.UsuarioId)
                .IsRequired();
        }
    }
}
