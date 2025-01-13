* Open solution;
* Ensure the EntityFramework NuGet is installed (check the NuGet tool window in Rider);
* Go to WcfService1/App.config;
* Ensure the connection string is valid and points to a proper database `connectionString="Server=localhost;Database=blog;Trusted_Connection=True;"`
* Establish connection to via "Databases" tool window;
* Right-click on project name in explorer and select "Entity Framework | Enable Migrations";
* Select "Ok";
* Right-click on project name in explorer and select "Entity Framework | Add Migration";
* See how the migration .cs file generates (under Migrations folder);
* Right-click on project name in explorer and select "Entity Framework | Update Database";
* If you want the queries to execute, just select "Ok";
  * Ticking the "Script" checkbox -> "Ok", you can preview sql queries. Rider will open them, so you can run them manually;
* Verify the updates to reflect database (3 tables should get created);