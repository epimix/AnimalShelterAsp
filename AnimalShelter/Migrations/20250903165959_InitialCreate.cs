using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimalShelter.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animals_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Коти" },
                    { 2, "Собаки" },
                    { 3, "Хомяки" },
                    { 4, "Мишки" },
                    { 5, "Птахи" },
                    { 6, "Риби" },
                    { 7, "Кролики" },
                    { 8, "Рептилії" },
                    { 9, "Інші" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "CategoryId", "Description", "Gender", "ImageUrl", "Name", "Status" },
                values: new object[,]
                {
                    { 1, 2, 1, "Ласкавий кіт, любить гратися з м'ячиками. Дуже дружелюбний до людей.", "Самець", "https://i.pinimg.com/736x/69/d4/f5/69d4f553a801270cc080e78402855353.jpg", "Мурчик", "Доступний" },
                    { 2, 3, 2, "Дружелюбний пес, добре ладнає з дітьми. Потребує активних прогулянок.", "Самець", "https://i.pinimg.com/736x/04/4d/b2/044db22d01a17a872b78b93f98d4b948.jpg", "Рекс", "Доступний" },
                    { 3, 0, 3, "Маленький хомячок, дуже активний. Любить бігати в колесі.", "Самка", "https://i.pinimg.com/736x/5e/ca/a9/5ecaa9e7ed0a5f4933d1a9ffccb78f9d.jpg", "Хомка", "Доступний" },
                    { 4, 0, 4, "Мишка-декоративна, дуже мила. Ідеально підходить для дітей.", "Самка", "https://i.pinimg.com/736x/fc/fb/97/fcfb97ed81a0c03ce4bfdfeb82870d7f.jpg", "Мішка", "Доступний" },
                    { 5, 1, 5, "Папуга, вміє говорити кілька слів. Дуже розумний і веселий.", "Самець", "https://i.pinimg.com/736x/7a/b2/45/7ab2455981b1a5caa622b4372da2988f.jpg", "Кеша", "Доступний" },
                    { 6, 0, 6, "Красиві золоті рибки для акваріуму. Потребують спеціального догляду.", "Невідомо", "https://i.pinimg.com/1200x/c8/65/33/c86533f9898ea801e4e47edac4fdc1f0.jpg", "Золота рибка", "Доступний" },
                    { 7, 0, 7, "Білий кролик, дуже пухнастий. Любить моркву та зелень.", "Самка", "https://i.pinimg.com/736x/61/57/e8/6157e8486c7b0edd02f7c23e8e843dcd.jpg", "Кролик Білий", "Доступний" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_CategoryId",
                table: "Animals",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
