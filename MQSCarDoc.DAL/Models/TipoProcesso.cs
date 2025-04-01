using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MQSCarDoc.Models
{
    [Table("TipoProcesso")]
    public partial class TipoProcesso
    {
        [Key]
        public int ID { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }
    }
}
