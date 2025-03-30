namespace MQSCarDocFrontend.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Fornecedor")]
    public partial class Fornecedor
    {
        public Fornecedor() { }
        public Fornecedor(int iD, int? endereco_ID, string nome, bool? ativo, string telefone, string celular, string email, 
                          Endereco endereco)
        {
            ID = iD;
            Endereco_ID = endereco_ID;
            Nome = nome;
            Ativo = ativo;
            Telefone = telefone;
            Celular = celular;
            Email = email;
            Endereco = endereco;
        }

        public int ID { get; set; }

        public int? Endereco_ID { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        public bool? Ativo { get; set; }

        [StringLength(20)]
        public string Telefone { get; set; }

        [StringLength(20)]
        public string Celular { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public virtual Endereco Endereco { get; set; }
    }
}
