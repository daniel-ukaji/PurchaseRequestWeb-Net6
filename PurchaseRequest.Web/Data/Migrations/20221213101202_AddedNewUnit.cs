using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Web.Data.Migrations
{
    public partial class AddedNewUnit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "898c75aa-a8a3-4b06-a1b9-e2decce0c8ab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "b3acb58b-ac7d-46e5-8d0e-e8b85334157e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40232b94-2c16-4e72-8318-92e1fc8daaa5", "AQAAAAEAACcQAAAAEE3WFZ8ehkgByxy3OMWpVQysZsV6rsMUloMBrw97D7/lRo7WKbIeIOPN8jfAX3A3Ww==", "72cbde31-8894-4549-87d0-824631f22bec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b7e1ea9-a91c-4a73-9b80-3dd51c70d561", "AQAAAAEAACcQAAAAEHUWGZvAHHX7Hp03osLVT93PsIeFq/gmIbXTIWjPByVsop2gY7M2sy4V115lWTAMvg==", "2828dbe5-15eb-4a35-9fd3-ffed421abb9b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unit",
                table: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "fb064fb1-27c2-4986-8a2b-af8a2c4170d5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "d661689f-f993-4302-b111-5f7d050b5a7d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60a225a2-0148-468b-b852-1a3d02c2b003", "AQAAAAEAACcQAAAAEPpB4DkZuBfbPEJ2ZxEJ+9MXLbkqRpdi6FBrlZ6mpfUz6aFy3HeAcWcqLX5Cd78l8w==", "248ea4e8-d521-4ab1-a87a-c539a147a2af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60e2b22f-3a36-4c32-84f8-50661c2a1911", "AQAAAAEAACcQAAAAENlDI+vA1y6ByVmoCuM8JQWhTpoqvXBB5f6xZtcYc/ExfVDxvigTbfTjZ0BKUbUhlg==", "6fcd29c1-6cf1-4f6c-9ed5-220d4214d464" });
        }
    }
}
