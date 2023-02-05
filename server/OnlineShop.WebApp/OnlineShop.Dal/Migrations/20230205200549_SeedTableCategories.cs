using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineShop.Dal.Migrations
{
    public partial class SeedTableCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryImage", "CategoryName" },
                values: new object[,]
                {
                    { 1, "https://i.pinimg.com/564x/33/db/25/33db259e2b81912d310f8e662a8df978.jpg", "Coats" },
                    { 2, "https://i.pinimg.com/564x/67/89/99/678999e2b02a0e0df8e008c1ceeef56c.jpg", "Gym Clothes" },
                    { 3, "https://i.pinimg.com/564x/67/59/0b/67590bf349a8f6dc016dac3ff3fd9c14.jpg", "Jeans" },
                    { 4, "https://i.pinimg.com/564x/07/a0/d5/07a0d5a33b8f4168ef6ec4c03944ad92.jpg", "Hoodies" },
                    { 5, "https://i.pinimg.com/564x/31/e6/a5/31e6a56cc424e4ce13153568489277de.jpg", "Vests" },
                    { 6, "https://i.pinimg.com/564x/c3/2f/7a/c32f7a60a8fa5335e83c3cc82795c609.jpg", "T-Shirts" },
                    { 7, "https://i.pinimg.com/564x/3d/81/de/3d81dedfd3a51be3175291d9d34b4fca.jpg", "Skirts" },
                    { 8, "https://i.pinimg.com/564x/14/4e/26/144e26c0bcce43eb12ff83518188b87d.jpg", "Shorts" },
                    { 9, "https://i.pinimg.com/564x/88/a7/87/88a7879cd516666f15cf3bbe458ba169.jpg", "Sweaters" },
                    { 10, "https://i.pinimg.com/564x/09/c3/0f/09c30fdf441f01e4c17712252c54436e.jpg", "Shirts" },
                    { 11, "https://i.pinimg.com/564x/dc/b2/99/dcb29963df0ee7aec9843e2bf7e4d598.jpg", "Swimsuits" },
                    { 12, "https://i.pinimg.com/564x/75/8a/f1/758af14dc0f392d1d1f47126a35d7762.jpg", "Pajamas" },
                    { 13, "https://i.pinimg.com/564x/e8/09/6d/e8096d13866fa0d9ad3f554a85d7a40f.jpg", "Sheath Dresses" },
                    { 14, "https://i.pinimg.com/564x/b4/24/27/b42427e7a1e8ca9272cdfc7ac44fbda4.jpg", "Scarfs" },
                    { 15, "https://i.pinimg.com/564x/72/4a/53/724a53d910fc333bfb10526c6c2b8e32.jpg", "Raincoats" },
                    { 16, "https://i.pinimg.com/564x/c6/bc/58/c6bc5809fefe0f39d5f796953655909a.jpg", "Tracksuits" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
