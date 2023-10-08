namespace AnkiCollab.Db.Models;

class OptionalTag
{
    [Required]
    [Column("id")]
    public int Id { get; init; }

    [Required]
    [Column("tag_group")]
    public string TagGroup { get; set; } = null!;

    [Required]
    [Column("deck")]
    public int DeckId { get; set; }

    public Deck? Deck { get; set; }
}