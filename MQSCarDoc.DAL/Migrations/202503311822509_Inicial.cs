namespace MQSCarDocFrontend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Endereco_ID = c.Int(),
                        Nome = c.String(maxLength: 100, unicode: false),
                        Ativo = c.Boolean(),
                        Celular = c.String(maxLength: 20, unicode: false),
                        Telefone = c.String(maxLength: 20, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Endereco", t => t.Endereco_ID, cascadeDelete: true)
                .Index(t => t.Endereco_ID);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        IdEndereco = c.Int(nullable: false, identity: true),
                        Rua = c.String(nullable: false, maxLength: 50, unicode: false),
                        Complemento = c.String(maxLength: 50, unicode: false),
                        Numero = c.String(maxLength: 10, unicode: false),
                        Cidade = c.String(maxLength: 50, unicode: false),
                        Estado = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.IdEndereco);
            
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Endereco_ID = c.Int(),
                        Nome = c.String(maxLength: 100, unicode: false),
                        Ativo = c.Boolean(),
                        Celular = c.String(maxLength: 20, unicode: false),
                        Telefone = c.String(maxLength: 20, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Endereco", t => t.Endereco_ID, cascadeDelete: true)
                .Index(t => t.Endereco_ID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Empresa_ID = c.Int(),
                        UserName = c.String(maxLength: 100, unicode: false),
                        SenhaUser = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Empresa", t => t.Empresa_ID, cascadeDelete: true)
                .Index(t => t.Empresa_ID);
            
            CreateTable(
                "dbo.PermissaoUsuario",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false),
                        PermissaoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UsuarioId, t.PermissaoId })
                .ForeignKey("dbo.Permissao", t => t.PermissaoId, cascadeDelete: true)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId)
                .Index(t => t.PermissaoId);
            
            CreateTable(
                "dbo.Permissao",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Empresa_ID = c.Int(),
                        NomePermissao = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Endereco_ID = c.Int(),
                        Nome = c.String(maxLength: 100, unicode: false),
                        Ativo = c.Boolean(),
                        Telefone = c.String(maxLength: 20, unicode: false),
                        Celular = c.String(maxLength: 20, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Endereco", t => t.Endereco_ID, cascadeDelete: true)
                .Index(t => t.Endereco_ID);
            
            CreateTable(
                "dbo.Funcionario",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Endereco_ID = c.Int(),
                        Nome = c.String(maxLength: 100, unicode: false),
                        Ativo = c.Boolean(),
                        Celular = c.String(maxLength: 20, unicode: false),
                        Telefone = c.String(maxLength: 20, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Endereco", t => t.Endereco_ID, cascadeDelete: true)
                .Index(t => t.Endereco_ID);
            
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Usuario_ID = c.Int(),
                        Nome = c.String(maxLength: 100, unicode: false),
                        Modelo_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Modelo", t => t.Modelo_ID)
                .Index(t => t.Modelo_ID);
            
            CreateTable(
                "dbo.Modelo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TipoProcesso",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.View_Cliente",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        IdEndereco = c.Int(nullable: false),
                        Rua = c.String(nullable: false, maxLength: 50, unicode: false),
                        Endereco_ID = c.Int(),
                        Nome = c.String(maxLength: 100, unicode: false),
                        Ativo = c.Boolean(),
                        Celular = c.String(maxLength: 20, unicode: false),
                        Telefone = c.String(maxLength: 20, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                        Complemento = c.String(maxLength: 50, unicode: false),
                        Numero = c.String(maxLength: 10, unicode: false),
                        Cidade = c.String(maxLength: 50, unicode: false),
                        Estado = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.ID, t.IdEndereco, t.Rua });
            
            CreateTable(
                "dbo.View_Fornecedor",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        IdEndereco = c.Int(nullable: false),
                        Rua = c.String(nullable: false, maxLength: 50, unicode: false),
                        Endereco_ID = c.Int(),
                        Nome = c.String(maxLength: 100, unicode: false),
                        Ativo = c.Boolean(),
                        Telefone = c.String(maxLength: 20, unicode: false),
                        Celular = c.String(maxLength: 20, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                        Complemento = c.String(maxLength: 50, unicode: false),
                        Numero = c.String(maxLength: 10, unicode: false),
                        Cidade = c.String(maxLength: 50, unicode: false),
                        Estado = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.ID, t.IdEndereco, t.Rua });
            
            CreateTable(
                "dbo.View_Funcionario",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        IdEndereco = c.Int(nullable: false),
                        Rua = c.String(nullable: false, maxLength: 50, unicode: false),
                        Endereco_ID = c.Int(),
                        Nome = c.String(maxLength: 100, unicode: false),
                        Ativo = c.Boolean(),
                        Celular = c.String(maxLength: 20, unicode: false),
                        Telefone = c.String(maxLength: 20, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                        Complemento = c.String(maxLength: 50, unicode: false),
                        Numero = c.String(maxLength: 10, unicode: false),
                        Cidade = c.String(maxLength: 50, unicode: false),
                        Estado = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.ID, t.IdEndereco, t.Rua });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Marca", "Modelo_ID", "dbo.Modelo");
            DropForeignKey("dbo.Funcionario", "Endereco_ID", "dbo.Endereco");
            DropForeignKey("dbo.Fornecedor", "Endereco_ID", "dbo.Endereco");
            DropForeignKey("dbo.Empresa", "Endereco_ID", "dbo.Endereco");
            DropForeignKey("dbo.Usuario", "Empresa_ID", "dbo.Empresa");
            DropForeignKey("dbo.PermissaoUsuario", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.PermissaoUsuario", "PermissaoId", "dbo.Permissao");
            DropForeignKey("dbo.Cliente", "Endereco_ID", "dbo.Endereco");
            DropIndex("dbo.Marca", new[] { "Modelo_ID" });
            DropIndex("dbo.Funcionario", new[] { "Endereco_ID" });
            DropIndex("dbo.Fornecedor", new[] { "Endereco_ID" });
            DropIndex("dbo.PermissaoUsuario", new[] { "PermissaoId" });
            DropIndex("dbo.PermissaoUsuario", new[] { "UsuarioId" });
            DropIndex("dbo.Usuario", new[] { "Empresa_ID" });
            DropIndex("dbo.Empresa", new[] { "Endereco_ID" });
            DropIndex("dbo.Cliente", new[] { "Endereco_ID" });
            DropTable("dbo.View_Funcionario");
            DropTable("dbo.View_Fornecedor");
            DropTable("dbo.View_Cliente");
            DropTable("dbo.TipoProcesso");
            DropTable("dbo.Modelo");
            DropTable("dbo.Marca");
            DropTable("dbo.Funcionario");
            DropTable("dbo.Fornecedor");
            DropTable("dbo.Permissao");
            DropTable("dbo.PermissaoUsuario");
            DropTable("dbo.Usuario");
            DropTable("dbo.Empresa");
            DropTable("dbo.Endereco");
            DropTable("dbo.Cliente");
        }
    }
}
