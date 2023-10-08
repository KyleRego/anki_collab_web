# Using EF Core to create a database

.NET Entity Framework Core can be used to scaffold a database schema from an entity model consisting of classes that are mapped into database tables. The properties of the entity classes can become columns in the tables but the object-relational mapping is very flexible in this ORM framework.

The .NET runtime will need to be installed (which includes the SDK).

To install the CLI for Entity Framework:

```
dotnet tool install --global dotnet-ef
```

`dotnet --help` and `dotnet ef --help` can be used to get help after install.

After changes to the models have been made, migrations can be generated using the `dotnet ef migrations add` command taking a migration name argument. The migrations can then be executed to update the database using `dotnet ef database update`. This is considered "design time" and the configuration for the database that is created is the class which implements the `IDesignTimeDbContextFactory<T>` interface. The derived `DbContext` class is where it is specified what classes become tables in the model. For example, if the derived DbContext had a property `DbSet<Car> Cars { get; set; }` then the Car class would map to the Cars table.

Currently the design time factory class is set to create the database `anki`

# Inspecting SQLite database with sqlite3

Use the sqlite3 CLI to inspect the database (`sqlite3 anki.db`). Once connected, `select * from sqlite_master` is a quick way to see the schema. Use .q to exit the sqlite3 CLI.
