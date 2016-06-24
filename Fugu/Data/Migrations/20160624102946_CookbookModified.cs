using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fugu.Data.Migrations
{
    public partial class CookbookModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Cookbooks");

            migrationBuilder.AddColumn<DateTime>(
                name: "Inserted",
                table: "Cookbooks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "Cookbooks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Inserted",
                table: "Cookbooks");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "Cookbooks");

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Cookbooks",
                nullable: true);
        }
    }
}
