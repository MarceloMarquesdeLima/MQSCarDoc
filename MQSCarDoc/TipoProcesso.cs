namespace MQSCarDocFrontend
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoProcesso")]
    public partial class TipoProcesso
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }
    }
}
