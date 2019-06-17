using FluentMigrator;

namespace Auth.Migration
{
    [Migration(20190616151500)]
    public class CreateTable_test : FluentMigrator.Migration
    {
        public override void Up()
        {
            Execute.Sql(@"
                CREATE TABLE test(
                 [id] INTEGER IDENTITY(1,1) NOT NULL,
                 [name] nvarchar(50) NOT NULL)
            ");
        }

        public override void Down()
        {
            Delete.Table("test");
        }
    }
}