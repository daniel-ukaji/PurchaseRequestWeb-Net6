using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Web.Data.Migrations
{
    public partial class AddedNewPurchaseItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PurchaseItems",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchaseItems",
                table: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "e7e67e60-e7bf-4ad4-8575-c60f79edb774");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "7368355b-315f-4ad8-9772-9cbddfd56c6e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b388da1-f4d0-4087-a036-27e72a82a4f3", "AQAAAAEAACcQAAAAEA2z8mAPpdjtVZxXp/9Q29S6XUY65HwbZw9DrHwdgD0gMktC/ih+vT2hW/46mq5c/A==", "119b366a-111e-4711-9663-4d61b0d58f0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14d5acab-5de0-4ca4-91dd-b1f968a26e80", "AQAAAAEAACcQAAAAEEZ0ib2l/Tp8/Z/Xe6980YpVm1gy9IoYQZXM1s/0/5zYXzwzcP251XC+1PUUVp7BVw==", "4ab75269-5963-46e9-a960-67a24f60ee26" });
        }
    }
}
