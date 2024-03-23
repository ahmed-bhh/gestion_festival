using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class applyconfiguration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtisteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nationalite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtisteId);
                });

            migrationBuilder.CreateTable(
                name: "Festivals",
                columns: table => new
                {
                    FestivalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacite = table.Column<int>(type: "int", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Festivals", x => x.FestivalId);
                });

            migrationBuilder.CreateTable(
                name: "Chansons",
                columns: table => new
                {
                    ChansonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateSortie = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duree = table.Column<int>(type: "int", nullable: false),
                    styleMusical = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    VuesYoutube = table.Column<int>(type: "int", nullable: false),
                    ArtisteFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chansons", x => x.ChansonId);
                    table.ForeignKey(
                        name: "FK_Chansons_Artists_ArtisteFK",
                        column: x => x.ArtisteFK,
                        principalTable: "Artists",
                        principalColumn: "ArtisteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Concerts",
                columns: table => new
                {
                    DateConcert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArtisteFK = table.Column<int>(type: "int", nullable: false),
                    FestivalFK = table.Column<int>(type: "int", nullable: false),
                    Cachet = table.Column<double>(type: "float", nullable: false),
                    Duree = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concerts", x => x.DateConcert);
                    table.ForeignKey(
                        name: "FK_Concerts_Artists_ArtisteFK",
                        column: x => x.ArtisteFK,
                        principalTable: "Artists",
                        principalColumn: "ArtisteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Concerts_Festivals_FestivalFK",
                        column: x => x.FestivalFK,
                        principalTable: "Festivals",
                        principalColumn: "FestivalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chansons_ArtisteFK",
                table: "Chansons",
                column: "ArtisteFK");

            migrationBuilder.CreateIndex(
                name: "IX_Concerts_ArtisteFK",
                table: "Concerts",
                column: "ArtisteFK");

            migrationBuilder.CreateIndex(
                name: "IX_Concerts_FestivalFK",
                table: "Concerts",
                column: "FestivalFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chansons");

            migrationBuilder.DropTable(
                name: "Concerts");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Festivals");
        }
    }
}
