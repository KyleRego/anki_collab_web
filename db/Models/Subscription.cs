namespace AnkiCollab.Db.Models;

[Table("subscriptions")]
class Subscription
{
    [Required]
    [Column("id")]
    public int Id { get; init; }

    [Required]
    [Column("deck_id")]
    public int DeckId { get; set; }

    public Deck? Deck { get; set; }
}