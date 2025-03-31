namespace MQSCarDocFrontend.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Modelo")]
    public partial class Modelo
    {
        public int ID { get; set; }

        public int? Usuario_ID { get; set; }

        public int? Marca_ID { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        public virtual Marca Marca { get; set; }
    }
}
