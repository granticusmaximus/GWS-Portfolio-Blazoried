using Microsoft.EntityFrameworkCore.Migrations;

namespace GWBlazor.Server.Migrations
{
    public partial class EntityUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e2ab2c1-6687-418e-bd93-feff6a429232");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fba21dc-7f80-43b9-8253-ed6fbbc9697b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe82f0e7-116a-43c4-8f52-9baac0fb490e");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Posts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "992ea004-48ad-4375-96c2-f3cb0ca04256", "9b396bcd-1434-41fe-a95c-d29081130b12", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b9275d20-7293-4997-8f82-4df1d6f1193a", "3d73d2ce-6fae-469f-82ef-457bc9b99820", "Author", "AUTHOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c2a7a8c7-80a7-4919-b2a3-98e5729da184", "14470b23-4ee9-4fb6-a37d-13cb7c538c2a", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "992ea004-48ad-4375-96c2-f3cb0ca04256");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9275d20-7293-4997-8f82-4df1d6f1193a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2a7a8c7-80a7-4919-b2a3-98e5729da184");

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Posts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8fba21dc-7f80-43b9-8253-ed6fbbc9697b", "b2715321-870d-4d00-a65b-c901296f40ad", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e2ab2c1-6687-418e-bd93-feff6a429232", "b1309902-a509-4610-a586-ac46624f907f", "Author", "AUTHOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe82f0e7-116a-43c4-8f52-9baac0fb490e", "c778d165-9db6-4ab1-beab-e52da4f83cdf", "Administrator", "ADMINISTRATOR" });
        }
    }
}
