namespace AnkiCollab.Db.Models;

[Table("notes")]
class Note
{
    [Required]
    [Column("id")]
    public int Id { get; init; }

    [Required]
    [Column("deck")]
    public int DeckId { get; set; }

    public Deck? Deck { get; set; }

    [Required]
    [Column("guid")]
    public string Guid { get; set; } = null!;

    [Required]
    [Column("notetype")]
    public int NoteTypeId { get; set; }

    public NoteType? NoteType { get; set; }

    [Required]
    [Column("reviewed")]
    public bool Reviewed { get; set; }

    [Required]
    [Column("deleted")]
    public bool Deleted { get; set; }

    [Required]
    [Column("last_update")]
    public DateTimeOffset LastUpdate { get; set; }
}