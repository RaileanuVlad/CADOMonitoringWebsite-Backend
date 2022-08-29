using Microsoft.EntityFrameworkCore.Migrations;

namespace Segregare.Migrations
{
    public partial class Migratie14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Expert",
                table: "Scoli",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Finantari",
                table: "Scoli",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Msanitar",
                table: "Scoli",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mscolar",
                table: "Scoli",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Plan",
                table: "Scoli",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Romani",
                table: "Scoli",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Expert",
                table: "Scoli");

            migrationBuilder.DropColumn(
                name: "Finantari",
                table: "Scoli");

            migrationBuilder.DropColumn(
                name: "Msanitar",
                table: "Scoli");

            migrationBuilder.DropColumn(
                name: "Mscolar",
                table: "Scoli");

            migrationBuilder.DropColumn(
                name: "Plan",
                table: "Scoli");

            migrationBuilder.DropColumn(
                name: "Romani",
                table: "Scoli");
        }
    }
}
