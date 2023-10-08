namespace AnkiCollab.Db.Models;

[Table("notetype")]
class NoteType
{
    [Required]
    [Column("id")]
    public int Id { get; init; }

    [Required]
    [Column("name")]
    public string Name { get; set; } = null!;

    [Required]
    [Column("css")]
    public string Css { get; set; } = null!;

    [Required]
    [Column("owner")]
    public int OwnerId { get; set; }
}