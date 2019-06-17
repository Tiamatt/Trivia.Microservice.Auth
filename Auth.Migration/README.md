## Preparations
1. Create new 'Trivia.AuthDb' database in SQL Server
3. Create new 'TriviaAuthDb_Admin' login with 'db_owner' and 'public' role membership for 'Trivia.AuthDb'

## How to run migration
1. Set "Auth.Migration" as a StartUp project
2. Run the app in debug mode

## Results
1. Go to your database
2. If [dbo].[VersionInfo] table never existed before, the app creates it automatically
3. Check your migrations results in database

## Note
1. If for some reasons you need to make your migration script run again, then
remove target version from [dbo].[VersionInfo] table and run "Auth.Migration" again
2. "Auth.Migration" project has it's own "appsettings.json" file with "ConnectionString" property
Make sure you are pointing to correct database

## FluentMigrator
Link: https://fluentmigrator.github.io/articles/quickstart.html
