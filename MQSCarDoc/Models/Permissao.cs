namespace MQSCarDocFrontend.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Permissao")]
    public partial class Permissao
    {
        public int ID { get; set; }

        public int? Empresa_ID { get; set; }

        [StringLength(100)]
        public string NomePermissao { get; set; }

        public ICollection<PermissaoUsuario> Usuarios { get; set; }

    }
}
