using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RetroGame_Cafe.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminInDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PasswordHash", "Pseudo", "Role" },
                values: new object[] { 1, "lepetit.Pedestre@lion.kml", "Lepetit", "Pédestre", "$argon2id$v=19$m=16,t=2,p=1$S2FhbWVsb3R0$RMdfjijCRSLEaq9eu5U/tw", "le chevalier au lion", "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
