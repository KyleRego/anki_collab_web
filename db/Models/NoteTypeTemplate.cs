namespace AnkiCollab.Db.Models;

[Table("notetype_template")]
class NoteTypeTemplate
{
    [Required]
    [Column("id")]
    public int Id { get; init; }

    [Required]
    [Column("notetype")]
    public int NoteTypeId { get; set; }

    public NoteType NoteType { get; set; } = null!;

    [Required]
    [Column("position")]
    public int Position { get; set; }

    [Required]
    [Column("qfmt")]
    public string QuestionFormat { get; set; } = null!;

    [Required]
    [Column("afmt")]
    public string AnswerFormat { get; set; } = null!;
}