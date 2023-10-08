namespace AnkiCollab.Db.Models;

[Table("service_accounts")]
class ServiceAccount
{
    [Required]
    [Column("id")]
    public int Id { get; init; }

    [Required]
    [Column("google_data")]
    public string GoogleJsonData { get; set; } = null!;

    [Required]
    [Column("deck")]
    public int DeckId { get; set; }

    public Deck? Deck { get; set; }
}