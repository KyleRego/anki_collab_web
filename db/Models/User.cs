namespace AnkiCollab.Db.Models;

[Table("users")]
class User
{
    [Required]
    [Column("id")]
    public int Id { get; init; }

    [Required]
    [Column("email")]
    public string Email { get; set; } = null!;
}