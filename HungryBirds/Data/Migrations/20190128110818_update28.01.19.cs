using Microsoft.EntityFrameworkCore.Migrations;

namespace HungryBirds.Data.Migrations
{
    public partial class update280119 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                table: "Selection",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MealId",
                table: "Selection",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "Meals",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Selection");

            migrationBuilder.DropColumn(
                name: "MealId",
                table: "Selection");

            migrationBuilder.DropColumn(
                name: "Selected",
                table: "Meals");
        }
    }
}
