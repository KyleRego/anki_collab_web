namespace AnkiCollab.Db.Models;

[Table("notetype_field")]
class NoteTypeField
{
    [Required]
    [Column("id")]
    public int Id { get; init; }

    [Required]
    [Column("name")]
    public string Name { get; set; } = null!;

    [Required]
    [Column("position")]
    public int Position { get; set; }

    [Required]
    [Column("protected")]
    public bool Protected { get; set; }

    [Required]
    [Column("notetype")]
    public int NoteTypeId { get; set; }

    public NoteType? NoteType { get; set; }
}