using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Web.Data.Migrations
{
    public partial class AddedNewVendor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                value: "480d8417-93ef-4f3c-9df5-e1ccdf049e34");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "28c26807-6008-49e4-9a92-64617c6b71f8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c8e3b5c-ea7b-4c8f-bb4b-92caf356e458", "AQAAAAEAACcQAAAAEARmgz83zPuYoVWQTQj77zFAv4w+6cbQpOq2skOoeoa+I6c9QrBaEtauHVGnxQ2gqg==", "b08d31c0-725d-4d1a-be53-4fee1e75ac99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf701777-81bc-4c66-a45a-7036ce3600f9", "AQAAAAEAACcQAAAAELl3ztvXYxK/ntu3yywJhGQc6DyRxIjX1caI69JhKmebdK2R6j2NeHAoO/OmkZLFGg==", "45ccb617-870f-458f-9067-fa68937cb079" });
        }
    }
}
