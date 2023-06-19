namespace CinemaProjeto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NomeDaMigracao : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sessaos", "preco", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sessaos", "preco", c => c.Single(nullable: false));
        }
    }
}
