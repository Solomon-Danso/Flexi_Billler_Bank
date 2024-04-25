using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flexi_Biller_Back.Migrations
{
    /// <inheritdoc />
    public partial class FDFKWCBKFVFEVBFEBFEGFEHKFEKGHVEKHFEWGBKBFCBKJFHCHGKWQCKHGEFWGHBEFWKGFBBFVBCEBJBKBFEBCE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auth");
        }
    }
}
