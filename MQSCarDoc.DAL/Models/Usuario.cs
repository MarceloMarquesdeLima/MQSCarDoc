namespace MQSCarDoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [Key]
        public int ID { get; set; }

        public int? Empresa_ID { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(10)]
        public string SenhaUser { get; set; }

        public virtual Empresa Empresa { get; set; }

        public ICollection<PermissaoUsuario> Permissoes { get; set; }

    }
}
