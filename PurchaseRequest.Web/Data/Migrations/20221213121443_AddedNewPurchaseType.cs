using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Web.Data.Migrations
{
    public partial class AddedNewPurchaseType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DefaultDays",
                table: "LeaveTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "fe0e9e45-a57a-45e3-825d-1ba18c87c998");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "c5462c94-14bb-4d6d-8141-ad82fb4f4b8b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b260182-1caf-402c-b479-e46a1b2b6231", "AQAAAAEAACcQAAAAEFRc2qKVYlT/j/B3FrTJ43cf3idwLjkQL5l4O/0YgjyHqqitVN4RX4OWCT17rQodDw==", "d0eb5ddd-9d20-43ca-889a-efa133cef99d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f9d0751-a89a-4953-ad60-d6b3a022ca50", "AQAAAAEAACcQAAAAEJj+4gFkdR5PE3mxIrLXJZo/7vFtcA5VSz8J23GhgkxfVIaHf14Ci3x44EYAIShZdA==", "86c66215-9af2-462d-8921-8d565ae2ed05" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DefaultDays",
                table: "LeaveTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "e50f59ba-11a1-49db-9f81-87a58e26d76b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "764de073-4623-4140-9cf5-3f9c32ac3777");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "768ec56c-6de2-4a2d-a25c-c97ee216c09a", "AQAAAAEAACcQAAAAELVXf+bT2R3iMvq1RYDjkyTOViwGleHY/kXogqLnU8B+1fb9W0ebXCIT4u3NUjzTZA==", "6c0d9f00-33b5-4c56-8a9b-4f4ed954c00c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cde2571-50d9-4595-983b-b99aaf48f6b2", "AQAAAAEAACcQAAAAEB2OIeFF9EwA+WmxzfWx1GCeG8PX27eTpU9snIW/HlwVbk7/4oYKORMhjRoHWVpB6Q==", "f179fe46-9ca8-4f63-96d0-56ab6c2cf264" });
        }
    }
}
