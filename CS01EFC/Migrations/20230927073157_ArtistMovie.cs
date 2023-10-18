using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CS01EFC.Migrations
{
    /// <inheritdoc />
    public partial class ArtistMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtistMovie_Artist_ArtistsArtistId",
                table: "ArtistMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtistMovie_Movies_MoviesMovieId",
                table: "ArtistMovie");

            migrationBuilder.RenameColumn(
                name: "MoviesMovieId",
                table: "ArtistMovie",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "ArtistsArtistId",
                table: "ArtistMovie",
                newName: "ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_ArtistMovie_MoviesMovieId",
                table: "ArtistMovie",
                newName: "IX_ArtistMovie_MovieId");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "Duration", "Name" },
                values: new object[] { 180, "Dune" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "Duration", "GenreId" },
                values: new object[] { 150, 3 });

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistMovie_Artist_ArtistId",
                table: "ArtistMovie",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistMovie_Movies_MovieId",
                table: "ArtistMovie",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtistMovie_Artist_ArtistId",
                table: "ArtistMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtistMovie_Movies_MovieId",
                table: "ArtistMovie");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "ArtistMovie",
                newName: "MoviesMovieId");

            migrationBuilder.RenameColumn(
                name: "ArtistId",
                table: "ArtistMovie",
                newName: "ArtistsArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_ArtistMovie_MovieId",
                table: "ArtistMovie",
                newName: "IX_ArtistMovie_MoviesMovieId");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "Duration", "Name" },
                values: new object[] { 24, "One Piece" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "Duration", "GenreId" },
                values: new object[] { 180, 2 });

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistMovie_Artist_ArtistsArtistId",
                table: "ArtistMovie",
                column: "ArtistsArtistId",
                principalTable: "Artist",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistMovie_Movies_MoviesMovieId",
                table: "ArtistMovie",
                column: "MoviesMovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
