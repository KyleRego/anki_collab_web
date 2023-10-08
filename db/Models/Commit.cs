namespace AnkiCollab.Db.Models;

[Table("commits")]
class Commit
{
    [Required]
    [Column("commit_id")]
    public int Id { get; init; }

    [Required]
    [Column("rationale")]
    public string Rationale { get; set; } = null!;

    [Required]
    [Column("deck")]
    public int DeckId { get; set; }

    public Deck? Deck { get; set; }

    [Required]
    [Column("timestamp")]
    public DateTimeOffset Timestamp { get; set; }
}