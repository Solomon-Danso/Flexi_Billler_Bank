using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flexi_Biller_Back.Migrations
{
    /// <inheritdoc />
    public partial class FDFKWCBKFVFEVBFEBFEGFEHKFEKGHVEKHFEWGBKBFCBKJFHCHGKWQCKHGEFWGHBEFWKGFBBFVBCEBJBKBFEBC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortName",
                table: "Auth",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortName",
                table: "Auth");
        }
    }
}
