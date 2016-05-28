using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Fugu.Data.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
//            migrationBuilder.CreateTable(
//                name: "Category",
//                columns: table => new
//                {
//                    CategoryId = table.Column<int>(nullable: false)
//                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
//                    DisplayName = table.Column<string>(nullable: true),
//                    ParentCategoryId = table.Column<int>(nullable: true)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Category", x => x.CategoryId);
//                    table.ForeignKey(
//                        name: "FK_Category_Category_ParentCategoryId",
//                        column: x => x.ParentCategoryId,
//                        principalTable: "Category",
//                        principalColumn: "CategoryId",
//                        onDelete: ReferentialAction.Restrict);
//                });
//            migrationBuilder.CreateTable(
//                name: "Author",
//                columns: table => new
//                {
//                    AuthorId = table.Column<int>(nullable: false)
//                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
//                },  
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Author", x => x.AuthorId);
//                });
//
//            migrationBuilder.CreateTable(
//                "Cookbook",
//                table => new
//                {
//                    CookbookId = table.Column<int>()
//                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
//                    name = table.Column<string>(),
//                    AuthorId = table.Column<int>()
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Cookbook", x => x.CookbookId);
//                    table.ForeignKey(
//                        name: "FK_Author",
//                        column: x => x.AuthorId,
//                        principalTable: "Author",
//                        principalColumn: "AuthorId",
//                        onDelete: ReferentialAction.Restrict);
//                });
//            migrationBuilder.CreateTable(
//                "Recipe",
//                table => new
//                {
//                    RecipeId = table.Column<int>()
//                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
//                    name = table.Column<string>(),
//                    //ingredients = table.Column<List<string>>(),
//                    note = table.Column<string>(nullable: true),
//                    CookbookId = table.Column<int>()
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Recipe", x => x.RecipeId);
//                    table.ForeignKey(
//                        "FK_Cookbook",
//                        x => x.CookbookId,
//                        "Cookbook",
//                        "CookbookId",
//                        onDelete: ReferentialAction.Restrict
//                        );
//                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
//            migrationBuilder.DropTable("Recipe");
//            migrationBuilder.DropTable("Cookbook");
//            migrationBuilder.DropTable("Author");
//            migrationBuilder.DropTable("Category");
        }
    }
}
