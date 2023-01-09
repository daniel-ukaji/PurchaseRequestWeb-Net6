using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Web.Data.Migrations
{
    public partial class AddedNewProduction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AmountProduction",
                table: "LeaveRequests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BalancePayment",
                table: "LeaveRequests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Prepayment",
                table: "LeaveRequests",
                type: "int",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountProduction",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "BalancePayment",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "Prepayment",
                table: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "14219b36-b39f-4d54-aac7-a66fc3d6d3ca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "a0173f98-fa1c-4cdb-b44c-29ff144d5384");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6b4d171-2ca0-47d6-b4a7-521d360a2f15", "AQAAAAEAACcQAAAAEGYWgw5aSAd1rI4H7ghZPoYfGS2KhjVj9cYd664W4pYEXy+X+SlejDJpRJNAZpzVXQ==", "b2d5a7a3-7bde-4c4d-b76a-e10be19520b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42c444e3-0e97-441c-ac55-471a15eb7338", "AQAAAAEAACcQAAAAEMR0UULNoxSslyEDJKputyUGAfBX4xvMtyM1jdGo0wkfzY89yV5viLLOhKxyWOwZIQ==", "dda04b3c-bf7e-4c0a-a5f9-784cffe370de" });
        }
    }
}
