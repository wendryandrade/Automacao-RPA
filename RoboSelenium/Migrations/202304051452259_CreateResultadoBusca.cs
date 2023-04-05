namespace RoboSelenium.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateResultadoBusca : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ResultadoBuscas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Area = c.String(),
                        Autor = c.String(),
                        Descricao = c.String(),
                        DataPublicacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ResultadoBuscas");
        }
    }
}
