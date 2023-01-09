using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Web.Data.Migrations
{
    public partial class AddedNewDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "4f8ed1ed-0435-47de-9a9b-68c6b20ec16a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "ab087836-d733-451f-82c7-65fa70fcba46");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcd0d0a5-e43d-49c0-a582-d92c116e4591", "AQAAAAEAACcQAAAAEORHJrIAK9VmKd3092ZBu2apcdrR/ilagYRgcxFE7vY9cg0br9oekal0zjwT4fv5EQ==", "50e03671-8eb0-42ba-a988-5284426e7c38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb3b27eb-3e70-47d4-897d-d25500242a05", "AQAAAAEAACcQAAAAEABCBsDWRbGYtQmX0z/kWrHstUlHPe71l79SLYwLYxPQi2LNtaImV6fTzVzWU1Ahzw==", "5966fc34-f2bd-4c88-88a1-8eafaeb22dad" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "978e6ad5-2592-4248-845e-97c315214896");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "51d6c5de-f002-4c52-a44f-377260dca35d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82c4ba32-9c7a-4e06-ad05-9a581c6528ac", "AQAAAAEAACcQAAAAEDpxc10PBa7fsvMsirPjb0htWp2PT32AjJTGStwVt2Ypz70e+SMgNOalKtirm1SrQw==", "d230a203-276f-4b3e-ad51-cfe58f7507f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "718c8460-724b-44de-8d80-5456f59f8c3b", "AQAAAAEAACcQAAAAEIvQxEZ+UTWmHsgQR2cblJkTDgaSfk9dgX95CIIq6Iw0DuSSbTBDKgpqyohcOCR8ig==", "5e254333-6aeb-4e74-a671-3edf08c01d4d" });
        }
    }
}
