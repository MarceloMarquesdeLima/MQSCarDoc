namespace MQSCarDoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Marca")]
    public partial class Marca
    {
        [Key]
        public int ID { get; set; }

        public int Usuario_ID { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        public Modelo Modelo { get; set; }
    }
}
