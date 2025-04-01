using MQSCarDoc.DAL.Configuration;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MQSCarDoc.Models
{
    public partial class MQSCarDocContext : DbContext
    {
        public MQSCarDocContext()
            : base("Server=DESKTOP-VF9QGB6\\SQLEXPRESS;Database=MqsCar;User Id=sa;Password=''; Integrated Security=True;")
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Fornecedor> Fornecedor { get; set; }
        public virtual DbSet<Funcionario> Funcionario { get; set; }
        public virtual DbSet<Permissao> Permissao { get; set; }
        public virtual DbSet<PermissaoUsuario> PermissaoUsuario { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Modelo> Modelo { get; set; }
        public virtual DbSet<TipoProcesso> TipoProcessos { get; set; }
        public virtual DbSet<View_Cliente> View_Cliente { get; set; }
        public virtual DbSet<View_Fornecedor> View_Fornecedor { get; set; }
        public virtual DbSet<View_Funcionario> View_Funcionario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new EmpresaConfiguration());
            modelBuilder.Configurations.Add(new FornecedorConfiguration());
            modelBuilder.Configurations.Add(new FuncionarioConfiguration());
            modelBuilder.Configurations.Add(new MarcaConfiguration());
            modelBuilder.Configurations.Add(new ModeloConfiguration());
            modelBuilder.Configurations.Add(new PermissaoConfiguration());
            modelBuilder.Configurations.Add(new PermissaoUsuarioConfiguration());
            modelBuilder.Configurations.Add(new TipoProcessoConfiguration());
            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            base.OnModelCreating(modelBuilder);

        }
    }
}
