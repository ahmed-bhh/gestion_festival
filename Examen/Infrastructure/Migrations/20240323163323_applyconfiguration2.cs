using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class applyconfiguration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Concerts",
                table: "Concerts");

            migrationBuilder.DropIndex(
                name: "IX_Concerts_ArtisteFK",
                table: "Concerts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Concerts",
                table: "Concerts",
                columns: new[] { "ArtisteFK", "FestivalFK", "DateConcert" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Concerts",
                table: "Concerts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Concerts",
                table: "Concerts",
                column: "DateConcert");

            migrationBuilder.CreateIndex(
                name: "IX_Concerts_ArtisteFK",
                table: "Concerts",
                column: "ArtisteFK");
        }
    }
}
