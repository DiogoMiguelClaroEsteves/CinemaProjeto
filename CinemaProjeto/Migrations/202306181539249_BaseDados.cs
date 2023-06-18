namespace CinemaProjeto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BaseDados : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Salas", "Colunas", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Salas", "Filas", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Salas", "Filas", c => c.Int(nullable: false));
            AlterColumn("dbo.Salas", "Colunas", c => c.Int(nullable: false));
        }
    }
}
