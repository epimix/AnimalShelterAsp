using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelter.Migrations
{
    /// <inheritdoc />
    public partial class UpdateToAnimalShelter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Animals");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Animals",
                newName: "Age");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "Description", "Gender", "ImageUrl", "Name", "Status" },
                values: new object[] { 2, "Ласкавий кіт, любить гратися з м'ячиками. Дуже дружелюбний до людей.", "Самець", "https://images.unsplash.com/photo-1514888286974-6c03e2ca1dba?w=400", "Мурчик", "Доступний" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Gender", "ImageUrl", "Name", "Status" },
                values: new object[] { "Дружелюбний пес, добре ладнає з дітьми. Потребує активних прогулянок.", "Самець", "https://images.unsplash.com/photo-1552053831-71594a27632d?w=400", "Рекс", "Доступний" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "Description", "Gender", "ImageUrl", "Name", "Status" },
                values: new object[] { 0, "Маленький хомячок, дуже активний. Любить бігати в колесі.", "Самка", "https://images.unsplash.com/photo-1516726817505-f5ed825624d8?w=400", "Хомка", "Доступний" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "Gender", "ImageUrl", "Name", "Status" },
                values: new object[] { 4, "Мишка-декоративна, дуже мила. Ідеально підходить для дітей.", "Самка", "https://images.unsplash.com/photo-1518709268805-4e9042af2176?w=400", "Мішка", "Доступний" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CategoryId", "Description", "Gender", "ImageUrl", "Name", "Status" },
                values: new object[] { 1, 5, "Папуга, вміє говорити кілька слів. Дуже розумний і веселий.", "Самець", "https://images.unsplash.com/photo-1559827260-dc66d52bef19?w=400", "Кеша", "Доступний" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "CategoryId", "Description", "Gender", "ImageUrl", "Name", "Status" },
                values: new object[] { 0, 6, "Красиві золоті рибки для акваріуму. Потребують спеціального догляду.", "Невідомо", "https://images.unsplash.com/photo-1544551763-46a013bb70d5?w=400", "Золота рибка", "Доступний" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Description", "Gender", "ImageUrl", "Name", "Status" },
                values: new object[] { 7, "Білий кролик, дуже пухнастий. Любить моркву та зелень.", "Самка", "https://images.unsplash.com/photo-1585110396000-c9ffd4e4b308?w=400", "Кролик Білий", "Доступний" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Коти");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Собаки");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Хомяки");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Мишки");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Птахи");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Риби");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Кролики");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Рептилії");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Інші");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Animals");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Animals",
                newName: "Quantity");

            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Animals",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Discount", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { null, 10, "https://applecity.com.ua/image/cache/catalog/0iphone/ipohnex/iphone-x-black-1000x1000.png", "iPhone X", 650m, 5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { null, 0, "https://http2.mlstatic.com/D_NQ_NP_727192-CBT53879999753_022023-V.jpg", "PowerBall", 45.5m });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Discount", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { null, 15, "https://www.seekpng.com/png/detail/316-3168852_nike-air-logo-t-shirt-nike-t-shirt.png", "Nike T-Shirt", 189m, 3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { 1, null, 5, "https://sota.kh.ua/image/cache/data/Samsung-2/samsung-s23-s23plus-blk-01-700x700.webp", "Samsung S23", 1200m });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "Discount", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { 6, null, 0, "https://cdn.shopify.com/s/files/1/0046/1163/7320/products/69ee701e-e806-4c4d-b804-d53dc1f0e11a_grande.jpg", "Air Ball", 50m, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "Discount", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { 1, null, 10, "https://newtime.ua/image/import/catalog/mac/macbook_pro/MacBook-Pro-16-2019/MacBook-Pro-16-Space-Gray-2019/MacBook-Pro-16-Space-Gray-00.webp", "MacBook Pro 2019", 0m, 23 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { 2, null, 0, null, "Samsung S4", 440m });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Electronics");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Sport");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Fashion");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Home & Garden");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Transport");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Toys & Hobbies");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Musical Instruments");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Art");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Other");
        }
    }
}
