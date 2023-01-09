using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Web.Data.Migrations
{
    public partial class AddedNewPurchaseRequestss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdviceOnCost",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "AmountProduction",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "BalancePayment",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "Items",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "Power",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "Prepayment",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "VendorAddress",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "VendorName",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdviceOnCost",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AmountProduction",
                table: "LeaveRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BalancePayment",
                table: "LeaveRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDate",
                table: "LeaveRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Items",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Power",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Prepayment",
                table: "LeaveRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "LeaveRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VendorAddress",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VendorName",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "344a81f5-b9d9-42a9-921f-f96b068ce9b4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "b290cf55-4a63-4dfe-bd1f-de9ac1c2a83f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f7206f6-3c02-4aff-a200-8f5de034ad76", "AQAAAAEAACcQAAAAEEsPehXVzISMv6kturdgbd8F7miTRFyMoOujcFDMOxUJKx19khr1kOJSnGkOWIMeTA==", "3cef770b-e961-49fe-be31-a998f276f533" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fddc10f5-a004-4e74-b999-86f96e38c4de", "AQAAAAEAACcQAAAAEDlZFkTR8uq6dPa44NGtqt1ECbqKfm71b0l1KooDBk4Gl/Cep/pB1Fcrx4bfHFsJsg==", "18257f86-00b3-4ac1-b5c1-067f27c183ca" });
        }
    }
}
