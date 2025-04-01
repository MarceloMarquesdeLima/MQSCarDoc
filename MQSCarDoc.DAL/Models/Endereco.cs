namespace MQSCarDoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Endereco")]
    public partial class Endereco
    {
        public Endereco()
        {
            Cliente = new HashSet<Cliente>();
            Empresa = new HashSet<Empresa>();
            Fornecedor = new HashSet<Fornecedor>();
            Funcionario = new HashSet<Funcionario>();
        }

        [Key]
        public int IdEndereco { get; set; }

        [Required]
        [StringLength(50)]
        public string Rua { get; set; }

        [StringLength(50)]
        public string Complemento { get; set; }

        [StringLength(10)]
        public string Numero { get; set; }

        [StringLength(50)]
        public string Cidade { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }

        public virtual ICollection<Empresa> Empresa { get; set; }

        public virtual ICollection<Fornecedor> Fornecedor { get; set; }

        public virtual ICollection<Funcionario> Funcionario { get; set; }
    }
}
