using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Battleship.Migrations
{
	/// <inheritdoc />
	public partial class InitialCreate2 : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropColumn(
				name: "Birthyear",
				table: "Users");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AddColumn<int>(
				name: "Birthyear",
				table: "Users",
				type: "INTEGER",
				nullable: false,
				defaultValue: 0);
		}
	}
}
