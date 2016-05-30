using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Fugu.Models;

namespace Fugu.Migrations
{
    [DbContext(typeof(FuguContext))]
    [Migration("20160528034533_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fugu.Models.FuguModels.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Fugu.Models.FuguModels.Cookbook", b =>
                {
                    b.Property<int>("CookbookId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("CookbookId");

                    b.ToTable("Cookbooks");
                });

            modelBuilder.Entity("Fugu.Models.FuguModels.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("RecipeId");

                    b.HasKey("IngredientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Fugu.Models.FuguModels.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CookbookId");

                    b.Property<string>("Description");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("RecipeId");

                    b.HasIndex("CookbookId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Fugu.Models.FuguModels.Ingredient", b =>
                {
                    b.HasOne("Fugu.Models.FuguModels.Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fugu.Models.FuguModels.Recipe", b =>
                {
                    b.HasOne("Fugu.Models.FuguModels.Cookbook")
                        .WithMany()
                        .HasForeignKey("CookbookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
