using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelter.Migrations
{
    /// <inheritdoc />
    public partial class PetsPict : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://i.pinimg.com/736x/69/d4/f5/69d4f553a801270cc080e78402855353.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://i.pinimg.com/736x/04/4d/b2/044db22d01a17a872b78b93f98d4b948.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://i.pinimg.com/736x/5e/ca/a9/5ecaa9e7ed0a5f4933d1a9ffccb78f9d.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://i.pinimg.com/736x/fc/fb/97/fcfb97ed81a0c03ce4bfdfeb82870d7f.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://i.pinimg.com/736x/7a/b2/45/7ab2455981b1a5caa622b4372da2988f.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://i.pinimg.com/1200x/c8/65/33/c86533f9898ea801e4e47edac4fdc1f0.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://i.pinimg.com/736x/61/57/e8/6157e8486c7b0edd02f7c23e8e843dcd.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1514888286974-6c03e2ca1dba?w=400");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1552053831-71594a27632d?w=400");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1516726817505-f5ed825624d8?w=400");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1518709268805-4e9042af2176?w=400");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1559827260-dc66d52bef19?w=400");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1544551763-46a013bb70d5?w=400");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1585110396000-c9ffd4e4b308?w=400");
        }
    }
}
