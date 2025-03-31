using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQSCarDocFrontend.Models
{
    [Table("PermissaoUsuario")]
    public partial class PermissaoUsuario
    {
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public int PermissaoId { get; set; }
        public virtual Permissao Permissao { get; set; }
    }
}
