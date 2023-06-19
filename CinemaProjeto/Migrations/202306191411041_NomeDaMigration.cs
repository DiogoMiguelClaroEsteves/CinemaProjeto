namespace CinemaProjeto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NomeDaMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Filmes", "Categoria", c => c.String());
            AlterColumn("dbo.Filmes", "Duracao", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Filmes", "Duracao", c => c.Time(nullable: false, precision: 7));
            DropColumn("dbo.Filmes", "Categoria");
        }
    }
}
