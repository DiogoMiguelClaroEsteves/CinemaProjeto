namespace CinemaProjeto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bilhetes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Lugar = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Cliente_ID = c.Int(),
                        Funcionario_ID = c.Int(),
                        Sessao_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clientes", t => t.Cliente_ID)
                .ForeignKey("dbo.Funcionarios", t => t.Funcionario_ID)
                .ForeignKey("dbo.Sessaos", t => t.Sessao_ID)
                .Index(t => t.Cliente_ID)
                .Index(t => t.Funcionario_ID)
                .Index(t => t.Sessao_ID);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Numfiscal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Salario = c.Single(nullable: false),
                        Funcao = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sessaos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DataHora = c.DateTime(nullable: false),
                        preco = c.Single(nullable: false),
                        Sala_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Salas", t => t.Sala_ID)
                .Index(t => t.Sala_ID);
            
            CreateTable(
                "dbo.Salas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Colunas = c.Int(nullable: false),
                        Filas = c.Int(nullable: false),
                        Cinema_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cinemas", t => t.Cinema_ID)
                .Index(t => t.Cinema_ID);
            
            CreateTable(
                "dbo.Cinemas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Morada = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        activa = c.Boolean(nullable: false),
                        Filme_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Filmes", t => t.Filme_ID)
                .Index(t => t.Filme_ID);
            
            CreateTable(
                "dbo.Filmes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Duracao = c.Time(nullable: false, precision: 7),
                        Activo = c.Boolean(nullable: false),
                        Sessao_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Sessaos", t => t.Sessao_ID)
                .Index(t => t.Sessao_ID);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Morada = c.String(),
                        Cliente_ID = c.Int(),
                        Funcionario_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clientes", t => t.Cliente_ID)
                .ForeignKey("dbo.Funcionarios", t => t.Funcionario_ID)
                .Index(t => t.Cliente_ID)
                .Index(t => t.Funcionario_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pessoas", "Funcionario_ID", "dbo.Funcionarios");
            DropForeignKey("dbo.Pessoas", "Cliente_ID", "dbo.Clientes");
            DropForeignKey("dbo.Categorias", "Filme_ID", "dbo.Filmes");
            DropForeignKey("dbo.Filmes", "Sessao_ID", "dbo.Sessaos");
            DropForeignKey("dbo.Bilhetes", "Sessao_ID", "dbo.Sessaos");
            DropForeignKey("dbo.Sessaos", "Sala_ID", "dbo.Salas");
            DropForeignKey("dbo.Salas", "Cinema_ID", "dbo.Cinemas");
            DropForeignKey("dbo.Bilhetes", "Funcionario_ID", "dbo.Funcionarios");
            DropForeignKey("dbo.Bilhetes", "Cliente_ID", "dbo.Clientes");
            DropIndex("dbo.Pessoas", new[] { "Funcionario_ID" });
            DropIndex("dbo.Pessoas", new[] { "Cliente_ID" });
            DropIndex("dbo.Filmes", new[] { "Sessao_ID" });
            DropIndex("dbo.Categorias", new[] { "Filme_ID" });
            DropIndex("dbo.Salas", new[] { "Cinema_ID" });
            DropIndex("dbo.Sessaos", new[] { "Sala_ID" });
            DropIndex("dbo.Bilhetes", new[] { "Sessao_ID" });
            DropIndex("dbo.Bilhetes", new[] { "Funcionario_ID" });
            DropIndex("dbo.Bilhetes", new[] { "Cliente_ID" });
            DropTable("dbo.Pessoas");
            DropTable("dbo.Filmes");
            DropTable("dbo.Categorias");
            DropTable("dbo.Cinemas");
            DropTable("dbo.Salas");
            DropTable("dbo.Sessaos");
            DropTable("dbo.Funcionarios");
            DropTable("dbo.Clientes");
            DropTable("dbo.Bilhetes");
        }
    }
}
