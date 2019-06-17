## Preparations
1. Create new 'Trivia.AuthDb' database in SQL Server
3. Create new 'TriviaAuthDb_Admin' login with 'db_owner' and 'public' role membership for 'Trivia.AuthDb'

## How to run migration
1. Set 'Auth.Migration' as a StartUp project
2. Run the app in debug mode

## Results
1. Go to your database
2. If 'dbo.VersionInfo' table never existed before, the app creates it automatically
3. Check your migration results in database

## Note
- If for some reasons you need to run migration script again, then remove a target version from 'dbo.VersionInfo' table and run the project again.
- 'Auth.Migration' project has it's own 'appsettings.json' file with 'ConnectionString' property. Make sure you are pointing to a correct database.

## FluentMigrator
- Fluent Migrator is a migration framework for .NET
- Link: https://fluentmigrator.github.io/articles/quickstart.html
