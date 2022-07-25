using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "b2bf57b5-8dcd-42f6-adf5-5db347cdd899");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "3b6eed95-52f2-4bd6-940f-6cf51633d839");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4e40f14-0dee-477a-bd83-a4fea064879a", "AQAAAAEAACcQAAAAEA5u99YuZF1WHwjqBgckx92pFgwWA7OYsRjcWnCOXtFbvM6OrivRx6VSKSkCD/ZIBA==", "1a26384d-b027-4994-8d70-55e80ee335bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e856c48d-d8da-403b-9a17-820e043aae1c", "AQAAAAEAACcQAAAAEAojoZYjMavjazQizcGFx+03jRSqNglJPPYlO+zrCGcj7CrjP1HJhgAKO2t87spo1Q==", "49eb2bd8-e5a3-448a-9ec0-505eab0110f8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "3f3572e7-d297-425e-bcba-e034e6d2264f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "d806409f-bdd3-4364-ae42-48e1d0d07f78");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd2862d2-a740-43ec-b76e-92dc8b2cfdd1", "AQAAAAEAACcQAAAAEFLIWqZF8FMUto3ikzTPdm+dIzDzG3BZZjjKHYT/Y2pH8/mZTm/I8NNMF9YKAUC52w==", "19f82201-840f-47bb-94ab-9c95da5b9662" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28f7dc3b-6fa3-4a9d-ad09-588102e60e21", "AQAAAAEAACcQAAAAEJ9RXxyRc/bJE78oBYwN8deQIf56rvPgSOwtlK0HwZ47wRNfo/cqg0m9SBZvw1gU+A==", "c706ced1-fbaa-49bf-a552-b127c5c4713e" });
        }
    }
}
