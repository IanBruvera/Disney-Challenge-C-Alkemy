using Microsoft.EntityFrameworkCore.Migrations;

namespace Disney_Proyect_Akemy.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personajes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    Peso = table.Column<int>(nullable: false),
                    Historia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personajes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    PeliculasId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(nullable: true),
                    Calificacion = table.Column<int>(nullable: false),
                    Creacion = table.Column<int>(nullable: false),
                    PersonajesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.PeliculasId);
                    table.ForeignKey(
                        name: "FK_Peliculas_Personajes_PersonajesId",
                        column: x => x.PersonajesId,
                        principalTable: "Personajes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    SeriesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(nullable: true),
                    Calificacion = table.Column<int>(nullable: false),
                    Creacion = table.Column<int>(nullable: false),
                    PersonajesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.SeriesId);
                    table.ForeignKey(
                        name: "FK_Series_Personajes_PersonajesId",
                        column: x => x.PersonajesId,
                        principalTable: "Personajes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonajesPorPeliculas",
                columns: table => new
                {
                    PersonajesId = table.Column<int>(nullable: false),
                    PeliculasId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonajesPorPeliculas", x => new { x.PeliculasId, x.PersonajesId });
                    table.ForeignKey(
                        name: "FK_PersonajesPorPeliculas_Peliculas_PeliculasId",
                        column: x => x.PeliculasId,
                        principalTable: "Peliculas",
                        principalColumn: "PeliculasId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonajesPorPeliculas_Personajes_PersonajesId",
                        column: x => x.PersonajesId,
                        principalTable: "Personajes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonajesPorSeries",
                columns: table => new
                {
                    PersonajesId = table.Column<int>(nullable: false),
                    SeriesId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonajesPorSeries", x => new { x.SeriesId, x.PersonajesId });
                    table.ForeignKey(
                        name: "FK_PersonajesPorSeries_Personajes_PersonajesId",
                        column: x => x.PersonajesId,
                        principalTable: "Personajes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonajesPorSeries_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "SeriesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Peliculas_PersonajesId",
                table: "Peliculas",
                column: "PersonajesId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonajesPorPeliculas_PersonajesId",
                table: "PersonajesPorPeliculas",
                column: "PersonajesId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonajesPorSeries_PersonajesId",
                table: "PersonajesPorSeries",
                column: "PersonajesId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_PersonajesId",
                table: "Series",
                column: "PersonajesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonajesPorPeliculas");

            migrationBuilder.DropTable(
                name: "PersonajesPorSeries");

            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Personajes");
        }
    }
}
