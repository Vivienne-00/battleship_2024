using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Battleship.Migrations
{
    /// <inheritdoc />
    public partial class AddUserBirthyear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Birthyear",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthyear",
                table: "Users");
        }
    }
}
