using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HungryBirds.Data.Migrations
{
    public partial class initalmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Selection",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MealId",
                table: "Selection",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Selection",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Selection");

            migrationBuilder.DropColumn(
                name: "MealId",
                table: "Selection");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Selection");
        }
    }
}
