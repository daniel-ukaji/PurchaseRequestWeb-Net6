using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Web.Data.Migrations
{
    public partial class AddedNewManufacturer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "6e0acb82-6914-4b22-a529-4bf622dc493a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "843c1dfd-558c-4d2c-86b9-8d91b4348fea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "628efa84-597a-4b45-a102-5b60f09cc5f0", "AQAAAAEAACcQAAAAEESQ9CP2qVrvLPrCu0m2JnG5VsvGFoggzns/utZeZyI7nL/Sm6UOS1l3Kp5BaXkOfQ==", "f2eafbd6-0760-44d1-89d8-d33e535d325b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "870ace6b-37e9-4e1e-baed-4c22252bc44e", "AQAAAAEAACcQAAAAEMOVQIDzL8f/niTEmhnrm2TTeNUYjwH5oGv+yK/oIFOLz/WqK0+yNvoMMAA9HtIDpQ==", "3b8111b8-8be8-4960-bc63-ebb836c5b51a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "LeaveRequests");

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
    }
}
