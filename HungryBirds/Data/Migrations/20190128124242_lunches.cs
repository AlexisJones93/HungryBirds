using Microsoft.EntityFrameworkCore.Migrations;

namespace HungryBirds.Data.Migrations
{
    public partial class lunches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Selection");

            migrationBuilder.DropColumn(
                name: "MealId",
                table: "Selection");

            migrationBuilder.AddColumn<int>(
                name: "FridayId",
                table: "Selection",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MondayId",
                table: "Selection",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Selection",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ThuesdayId",
                table: "Selection",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TuesdayId",
                table: "Selection",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WednesdayId",
                table: "Selection",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Dayofweek",
                table: "Meals",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FridayId",
                table: "Selection");

            migrationBuilder.DropColumn(
                name: "MondayId",
                table: "Selection");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Selection");

            migrationBuilder.DropColumn(
                name: "ThuesdayId",
                table: "Selection");

            migrationBuilder.DropColumn(
                name: "TuesdayId",
                table: "Selection");

            migrationBuilder.DropColumn(
                name: "WednesdayId",
                table: "Selection");

            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                table: "Selection",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MealId",
                table: "Selection",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Dayofweek",
                table: "Meals",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
