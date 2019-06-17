using FluentMigrator;

namespace Auth.Migration.Mirgations
{
    [Migration(20190616184200)]
    public class CreateTable_account : FluentMigrator.Migration
    {
        public override void Up()
        {
            // Create new table "account"
            Execute.Sql(@"
                IF OBJECT_ID('dbo.account', 'U') IS NULL 
                BEGIN
                    CREATE TABLE dbo.account(
	                    [id] INTEGER IDENTITY(1,1),--  PRIMARY KEY,
	                    [uuid] uniqueidentifier NOT NULL CONSTRAINT [DF_account_uuid] DEFAULT NEWID(),
	                    [nickname] nvarchar(100) NOT NULL,
	                    [email] nvarchar(320) NULL,
	                    [firstName] nvarchar(100) NULL,
	                    [lastName] nvarchar(100) NULL,
	                    [initialLoginTypeId] INT NULL,
	                    [socialMediaIdentity] nvarchar(320) NULL,
	                    [timestamp] BIGINT NOT NULL CONSTRAINT [DF_account_timestamp] DEFAULT DATEDIFF(s, '1970-01-01', GETUTCDATE()),
	                    CONSTRAINT [PK_account_id] PRIMARY KEY CLUSTERED ([id] ASC),
	                    CONSTRAINT [FK_account_initialLoginTypeId] FOREIGN KEY ([initialLoginTypeId]) REFERENCES loginType(id)
                    )
                END
                GO
            ");
        }

        public override void Down()
        {
            // Delete.Table("account");
        }
    }
}
