using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dex_Filter.Migrations
{
    /// <inheritdoc />
    public partial class Initialll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "chainId",
                table: "Tokens",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tokens",
                newName: "chainId");
        }
    }
}
