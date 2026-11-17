using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RetroGame_Cafe.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Price = table.Column<double>(type: "float(2)", precision: 2, nullable: false),
                    IsVegie = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Fk_Categorie_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_Products_Categories_Fk_Categorie_Id",
                        column: x => x.Fk_Categorie_Id,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Fk_Categorie_Id",
                table: "Products",
                column: "Fk_Categorie_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
