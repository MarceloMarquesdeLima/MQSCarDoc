using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MQSCarDocFrontend.Models
{
    [Table("Cliente")]
    public partial class TipoProcesso
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }
    }
}
