namespace AnkiCollab.Db.Models;

[Table("maintainers")]
class Maintainer
{
    [Required]
    [Column("id")]
    public int Id { get; init; }

    [Required]
    [Column("deck")]
    public int DeckId { get; set; }

    public Deck? Deck { get; set; }

    [Required]
    [Column("user_id")]
    public int UserId { get; set; }

    public User? User { get; set; }
}