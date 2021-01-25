using Microsoft.EntityFrameworkCore.Migrations;

namespace GWBlazor.Server.Migrations
{
    public partial class InitialRoleSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
