using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Web.Data.Migrations
{
    public partial class AddedNewPurchaseRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "a81e28e9-be9c-4826-88c0-3358acab3846");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "6eee95e3-1e46-4e9b-bc47-1e0e6195d242");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2725fb9e-d7bc-420f-bae1-dde5f2c8c911", "AQAAAAEAACcQAAAAECueU20C1a3lBSoeoAO1yEms0edmpLefSqvyDuBjSy5D70Wa/2valfIVp4fLJZT8YQ==", "5aad9a2e-2b27-4289-bcce-122d4f02ea32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47319d20-ca6a-465c-a61c-edca02ee07a5", "AQAAAAEAACcQAAAAEJ3m3qaQXP/VULZibwMriQJWyaIg5t8p8IgNtEJtUfEEyAC2MA8XC/9qzPLKTGJVBw==", "1cf16f48-ad11-4b6b-83ed-55a46594eabf" });
        }
    }
}
