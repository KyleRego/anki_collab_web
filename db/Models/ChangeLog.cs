namespace AnkiCollab.Db.Models;

[Table("changelogs")]
class ChangeLog
{
    [Required]
    [Column("id")]
    public int Id { get; init; }

    [Required]
    [Column("deck")]
    public int DeckId { get; set; }

    [Required]
    [Column("message")]
    public string Message { get; set; } = null!;

    [Required]
    [Column("timestamp")]
    public DateTimeOffset Timestamp { get; set; }
}