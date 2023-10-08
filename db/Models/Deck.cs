namespace AnkiCollab.Db.Models;

[Table("decks")]
class Deck
{
    [Required]
    [Column("id")]
    public int Id { get; init; }

    [Required]
    [Column("owner")]
    public int OwnerId { get; set; }

    [Required]
    [Column("name")]
    public string Name { get; set; } = null!;

    [Required]
    [Column("description")]
    public string Description { get; set; } = null!;

    [Required]
    [Column("human_hash")]
    public string HumanHash { get; set; } = null!;

    [Required]
    [Column("private")]
    public bool Private { get; set; }

    [Required]
    [Column("last_update")]
    public DateTimeOffset LastUpdate { get; set; }

    [Column("parent")]
    public int ParentDeckId { get; set; }

    [Required]
    [Column("subscriptions")]
    public int SubscriptionsCount { get; set; }

    [Required]
    [Column("full_path")]
    public string FullPath { get; set; } = null!;
}