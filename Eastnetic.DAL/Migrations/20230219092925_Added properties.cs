using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eastnetic.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Addedproperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalSubElements",
                table: "Window");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalSubElements",
                table: "Window",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
