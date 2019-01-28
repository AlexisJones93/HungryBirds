using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HungryBirds.Data.Migrations
{
    public partial class updatemodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Selection");

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Selection",
                nullable: false,
                defaultValue: 0);

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
                name: "Selected",
                table: "Meals");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Selection",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
