using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace db.Migrations
{
    /// <inheritdoc />
    public partial class ScaffoldDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "decks",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    owner = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    human_hash = table.Column<string>(type: "text", nullable: false),
                    @private = table.Column<bool>(name: "private", type: "boolean", nullable: false),
                    last_update = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    parent = table.Column<int>(type: "integer", nullable: false),
                    subscriptions = table.Column<int>(type: "integer", nullable: false),
                    full_path = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_decks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "notetype",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    css = table.Column<string>(type: "text", nullable: false),
                    owner = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notetype", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "commits",
                columns: table => new
                {
                    commit_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rationale = table.Column<string>(type: "text", nullable: false),
                    deck = table.Column<int>(type: "integer", nullable: false),
                    timestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_commits", x => x.commit_id);
                    table.ForeignKey(
                        name: "FK_commits_decks_deck",
                        column: x => x.deck,
                        principalTable: "decks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "subscriptions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    deck_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subscriptions", x => x.id);
                    table.ForeignKey(
                        name: "FK_subscriptions_decks_deck_id",
                        column: x => x.deck_id,
                        principalTable: "decks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "notes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    deck = table.Column<int>(type: "integer", nullable: false),
                    guid = table.Column<string>(type: "text", nullable: false),
                    notetype = table.Column<int>(type: "integer", nullable: false),
                    reviewed = table.Column<bool>(type: "boolean", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false),
                    last_update = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notes", x => x.id);
                    table.ForeignKey(
                        name: "FK_notes_decks_deck",
                        column: x => x.deck,
                        principalTable: "decks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_notes_notetype_notetype",
                        column: x => x.notetype,
                        principalTable: "notetype",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "notetype_template",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    notetype = table.Column<int>(type: "integer", nullable: false),
                    position = table.Column<int>(type: "integer", nullable: false),
                    qfmt = table.Column<string>(type: "text", nullable: false),
                    afmt = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notetype_template", x => x.id);
                    table.ForeignKey(
                        name: "FK_notetype_template_notetype_notetype",
                        column: x => x.notetype,
                        principalTable: "notetype",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "fields",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    note = table.Column<int>(type: "integer", nullable: false),
                    reviewed = table.Column<bool>(type: "boolean", nullable: false),
                    content = table.Column<string>(type: "text", nullable: false),
                    position = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fields", x => x.id);
                    table.ForeignKey(
                        name: "FK_fields_notes_note",
                        column: x => x.note,
                        principalTable: "notes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_commits_deck",
                table: "commits",
                column: "deck");

            migrationBuilder.CreateIndex(
                name: "IX_fields_note",
                table: "fields",
                column: "note");

            migrationBuilder.CreateIndex(
                name: "IX_notes_deck",
                table: "notes",
                column: "deck");

            migrationBuilder.CreateIndex(
                name: "IX_notes_notetype",
                table: "notes",
                column: "notetype");

            migrationBuilder.CreateIndex(
                name: "IX_notetype_template_notetype",
                table: "notetype_template",
                column: "notetype");

            migrationBuilder.CreateIndex(
                name: "IX_subscriptions_deck_id",
                table: "subscriptions",
                column: "deck_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "commits");

            migrationBuilder.DropTable(
                name: "fields");

            migrationBuilder.DropTable(
                name: "notetype_template");

            migrationBuilder.DropTable(
                name: "subscriptions");

            migrationBuilder.DropTable(
                name: "notes");

            migrationBuilder.DropTable(
                name: "decks");

            migrationBuilder.DropTable(
                name: "notetype");
        }
    }
}
