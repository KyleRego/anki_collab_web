namespace AnkiCollab.Db.Models;

[Table("tags")]
class Tag
{
    [Required]
    [Column("id")]
    public int Id { get; init; }

    [Required]
    [Column("note")]
    public int NoteId { get; set; }

    public Note? Note { get; set; }

    [Required]
    [Column("reviewed")]
    public bool Reviewed { get; set; }

    [Required]
    [Column("content")]
    public string Content { get; set; } = null!;

    [Required]
    [Column("action")]
    public string Action { get; set; } = null!;
}