using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Web.Data.Migrations
{
    public partial class AddedNewDeliveryDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDate",
                table: "LeaveRequests",
                type: "datetime2",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "12bb373a-1f37-4121-a243-f453e07e32da");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "2eb70df1-0f22-4391-9c28-88c1a9911279");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bfa980e-18f0-48be-b0ec-1e6fca33e66d", "AQAAAAEAACcQAAAAELJ5mZ2sFdAs/hzsdfl2ETHCNczW2TOh0Q84bVpWnUWa3DNmzwVFauZo5nSYkXSJGA==", "d673ce7a-a328-41d9-bcc1-e2632742b43b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5562099-4a0c-48d6-9ada-c4340d127e39", "AQAAAAEAACcQAAAAEBYMWRCJHmWgT4w4QVIKKjnFilsE39n/Mci7Yd7Qo45lX7qkOJ+aEwYrz5JQg2p1FQ==", "e56eac98-4b67-4733-8401-ecb39b27e21a" });
        }
    }
}
