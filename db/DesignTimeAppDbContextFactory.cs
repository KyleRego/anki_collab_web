namespace AnkiCollab.Db;

class DesignTimeAppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        // optionsBuilder.UseSqlite("Data source=anki.db");
        optionsBuilder.UseNpgsql("Host=localhost;Database=anki;Username=postgres;Password=password");
        return new AppDbContext(optionsBuilder.Options);
    }
}