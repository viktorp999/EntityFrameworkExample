namespace EntityFrameworkExample.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        LastName = c.String(nullable: false, maxLength: 255),
                        Years = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            Sql("INSERT INTO People VALUES ('Viktor', 'Petrovski', 23)");
            Sql("INSERT INTO People VALUES ('Kire', 'Stojanovski', 60)");
            Sql("INSERT INTO People VALUES ('Martin', 'Sekulovski', 20)");
            Sql("INSERT INTO People VALUES ('Stefan', 'Talevski', 14)");
            Sql("INSERT INTO People VALUES ('Trajan', 'Petkovski', 66)");

        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
