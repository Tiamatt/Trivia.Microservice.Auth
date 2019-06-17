## How to run migration
1. Set "Auth.Migration" as a StartUp project
2. Run the app in debug mode

## Results
1. Go to your database
2. If [dbo].[VersionInfo] table never existed before, the app creates it
3. Check your migrations results in database

## Note
1. If for some reasons you need to make your migration script run again, then
remove target version from [dbo].[VersionInfo] table and run "Auth.Migration" again
