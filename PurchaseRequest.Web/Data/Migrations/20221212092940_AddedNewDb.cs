using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Web.Data.Migrations
{
    public partial class AddedNewDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
