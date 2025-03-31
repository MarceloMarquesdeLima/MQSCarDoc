using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQSCarDoc.Models
{
    [Table("Modelo")]
    public partial class Modelo
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
    }
}
