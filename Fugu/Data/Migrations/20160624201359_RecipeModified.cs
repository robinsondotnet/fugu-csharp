using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fugu.Data.Migrations
{
    public partial class RecipeModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Recipes");

            migrationBuilder.AddColumn<DateTime>(
                name: "Inserted",
                table: "Recipes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "Recipes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Inserted",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "Recipes");

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Recipes",
                nullable: true);
        }
    }
}
