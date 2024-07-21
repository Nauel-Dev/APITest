using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dex_Filter.Migrations
{
    /// <inheritdoc />
    public partial class Initiallll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Chain",
                table: "Tokens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chain",
                table: "Tokens");
        }
    }
}
  