using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cats.Db.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Breed",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Rare = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: true),
                    WeightKg = table.Column<double>(nullable: true),
                    BreedId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cats_Breed_BreedId",
                        column: x => x.BreedId,
                        principalTable: "Breed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Paw",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Size = table.Column<int>(nullable: true),
                    CatId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paw", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Paw_Cats_CatId",
                        column: x => x.CatId,
                        principalTable: "Cats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Breed",
                columns: new[] { "Id", "Name", "Rare" },
                values: new object[] { new Guid("ba015ad2-44fe-45eb-9bf5-313603e9f775"), "Aphrodite Giant", false });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "Birthday", "BreedId", "Name", "WeightKg" },
                values: new object[] { new Guid("a64ea9d9-3fe2-4556-9483-914138b79703"), new DateTime(2017, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Васька", null });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "Birthday", "BreedId", "Name", "WeightKg" },
                values: new object[] { new Guid("5d5689ed-b864-4da6-94f3-f036ab83d0d6"), new DateTime(2015, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ba015ad2-44fe-45eb-9bf5-313603e9f775"), "Муська", null });

            migrationBuilder.InsertData(
                table: "Paw",
                columns: new[] { "Id", "CatId", "Size", "Type" },
                values: new object[,]
                {
                    { new Guid("758d5931-531b-4ed2-ac9d-7c1142cf3792"), new Guid("a64ea9d9-3fe2-4556-9483-914138b79703"), null, 0 },
                    { new Guid("c9afd7ed-b6ff-4c79-aa38-654c55370ca3"), new Guid("a64ea9d9-3fe2-4556-9483-914138b79703"), null, 1 },
                    { new Guid("6bc3a507-b8a4-40a2-ac60-adcaf8da9916"), new Guid("a64ea9d9-3fe2-4556-9483-914138b79703"), null, 2 },
                    { new Guid("bf97d85f-f273-42f9-b1d4-6e99bfe23cca"), new Guid("a64ea9d9-3fe2-4556-9483-914138b79703"), null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Paw",
                columns: new[] { "Id", "CatId", "Size", "Type" },
                values: new object[,]
                {
                    { new Guid("9644fa54-b4e6-41f6-9765-d9ab888e2b0e"), new Guid("5d5689ed-b864-4da6-94f3-f036ab83d0d6"), null, 0 },
                    { new Guid("bed52cca-ee24-49e6-9f20-84f069c151e8"), new Guid("5d5689ed-b864-4da6-94f3-f036ab83d0d6"), null, 1 },
                    { new Guid("160a6376-16ed-4597-b769-f1203c588fcf"), new Guid("5d5689ed-b864-4da6-94f3-f036ab83d0d6"), null, 2 },
                    { new Guid("2c0361fc-b8b7-4599-8937-a081390aec60"), new Guid("5d5689ed-b864-4da6-94f3-f036ab83d0d6"), null, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cats_BreedId",
                table: "Cats",
                column: "BreedId");

            migrationBuilder.CreateIndex(
                name: "IX_Paw_CatId",
                table: "Paw",
                column: "CatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paw");

            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "Breed");
        }
    }
}
