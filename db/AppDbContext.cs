using AnkiCollab.Db.Models;

namespace AnkiCollab.Db;

class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Commit> Commits { get; set; }

    public DbSet<Deck> Decks { get; set; }

    public DbSet<Field> Fields { get; set; }

    public DbSet<Subscription> Subscriptions { get; set; }

    public DbSet<NoteType> Notetype { get; set; }

    public DbSet<NoteTypeTemplate> NotetypeTemplate { get; set; }

}