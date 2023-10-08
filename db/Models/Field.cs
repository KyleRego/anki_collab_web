namespace AnkiCollab.Db.Models;

[Table("fields")]
class Field
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
    [Column("position")]
    public int Position { get; set; }
}