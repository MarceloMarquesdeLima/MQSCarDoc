using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MQSCarDocFrontend.Models
{
    public partial class Models : DbContext
    {
        public Models()
            : base("name=Models")
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Fornecedor> Fornecedor { get; set; }
        public virtual DbSet<Funcionario> Funcionario { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<View_Cliente> View_Cliente { get; set; }
        public virtual DbSet<View_Fornecedor> View_Fornecedor { get; set; }
        public virtual DbSet<View_Funcionario> View_Funcionario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Rua)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .HasMany(e => e.Cliente)
                .WithOptional(e => e.Endereco)
                .HasForeignKey(e => e.Endereco_ID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Endereco>()
                .HasMany(e => e.Empresa)
                .WithOptional(e => e.Endereco)
                .HasForeignKey(e => e.Endereco_ID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Endereco>()
                .HasMany(e => e.Fornecedor)
                .WithOptional(e => e.Endereco)
                .HasForeignKey(e => e.Endereco_ID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Endereco>()
                .HasMany(e => e.Funcionario)
                .WithOptional(e => e.Endereco)
                .HasForeignKey(e => e.Endereco_ID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<View_Cliente>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<View_Cliente>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<View_Cliente>()
                .Property(e => e.Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<View_Cliente>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<View_Cliente>()
                .Property(e => e.Rua)
                .IsUnicode(false);

            modelBuilder.Entity<View_Cliente>()
                .Property(e => e.Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<View_Cliente>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<View_Cliente>()
                .Property(e => e.Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<View_Cliente>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<View_Fornecedor>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<View_Fornecedor>()
                .Property(e => e.Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<View_Fornecedor>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<View_Fornecedor>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<View_Fornecedor>()
                .Property(e => e.Rua)
                .IsUnicode(false);

            modelBuilder.Entity<View_Fornecedor>()
                .Property(e => e.Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<View_Fornecedor>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<View_Fornecedor>()
                .Property(e => e.Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<View_Fornecedor>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<View_Funcionario>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<View_Funcionario>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<View_Funcionario>()
                .Property(e => e.Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<View_Funcionario>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<View_Funcionario>()
                .Property(e => e.Rua)
                .IsUnicode(false);

            modelBuilder.Entity<View_Funcionario>()
                .Property(e => e.Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<View_Funcionario>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<View_Funcionario>()
                .Property(e => e.Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<View_Funcionario>()
                .Property(e => e.Estado)
                .IsUnicode(false);
        }
    }
}
