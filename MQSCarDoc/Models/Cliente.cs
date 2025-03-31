namespace MQSCarDocFrontend.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        public int ID { get; set; }

        public int? Endereco_ID { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        public bool? Ativo { get; set; }

        [StringLength(20)]
        public string Celular { get; set; }

        [StringLength(20)]
        public string Telefone { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public virtual Endereco Endereco { get; set; }
    }
}
