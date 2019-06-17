using FluentMigrator;

namespace Auth.Migration
{
    [Migration(20190616183500)]
    public class CreateTable_loginType : FluentMigrator.Migration
    {
        public override void Up()
        {
            // Create new table "loginType"
            Execute.Sql(@"
                IF OBJECT_ID('dbo.loginType', 'U') IS NULL 
                BEGIN
                    CREATE TABLE dbo.loginType(
                         [id] INTEGER IDENTITY(1,1) NOT NULL,
                         [name] nvarchar(50) NOT NULL,
                         [description] nvarchar(255) NOT NULL,
                         [isActive] bit DEFAULT(1) NOT NULL,
                         CONSTRAINT [PK_loginType_id] PRIMARY KEY CLUSTERED ([id] ASC)
                    )
                END
                GO
            ");

            // Insert initial rows in "loginType"
            Execute.Sql(@"
                IF NOT EXISTS(SELECT * FROM dbo.loginType WHERE [id] IN (1,2,3))
                BEGIN

                    SET IDENTITY_INSERT dbo.loginType ON;

	                INSERT INTO dbo.loginType([id],[name],[description]) VALUES 
                        (1, 'trivia', 'via Trivia'), 
                        (2, 'google', 'via Google'), 
                        (3, 'facebook', 'via Facebook')

                    SET IDENTITY_INSERT dbo.loginType OFF; 

                END
                GO
            ");
        }

        public override void Down()
        {
            // Delete.Table("loginType");
        }
    }
}