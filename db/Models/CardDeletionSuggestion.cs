namespace AnkiCollab.Db.Models;

[Table("card_deletion_suggestions")]
class CardDeletionSuggestion
{
    [Required]
    [Column("id")]
    public int Id { get; init; }

    [Required]
    [Column("note")]
    public int NoteId { get; set; }

    public Note? Note { get; set; }

    [Required]
    [Column("commit")]
    public int CommitId { get; set; }
}