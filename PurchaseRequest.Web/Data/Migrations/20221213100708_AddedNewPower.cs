using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Web.Data.Migrations
{
    public partial class AddedNewPower : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Power",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "fb064fb1-27c2-4986-8a2b-af8a2c4170d5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "d661689f-f993-4302-b111-5f7d050b5a7d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60a225a2-0148-468b-b852-1a3d02c2b003", "AQAAAAEAACcQAAAAEPpB4DkZuBfbPEJ2ZxEJ+9MXLbkqRpdi6FBrlZ6mpfUz6aFy3HeAcWcqLX5Cd78l8w==", "248ea4e8-d521-4ab1-a87a-c539a147a2af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60e2b22f-3a36-4c32-84f8-50661c2a1911", "AQAAAAEAACcQAAAAENlDI+vA1y6ByVmoCuM8JQWhTpoqvXBB5f6xZtcYc/ExfVDxvigTbfTjZ0BKUbUhlg==", "6fcd29c1-6cf1-4f6c-9ed5-220d4214d464" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Power",
                table: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "9da23594-e15a-4f3f-8e0f-8d313b55b95b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "6c6c2b5f-dccb-48fc-a5a5-3910b7885799");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8eb56c9-1d84-4abf-bd29-3b335ce49f68", "AQAAAAEAACcQAAAAEMqmhs1ytQFuARZKyxZFRvWMlZB0gDTd77fiyf817xCcPCo5yTFFpBFH7NdvLq91sQ==", "d12db597-b618-4374-a6bd-f99ab5aa2f53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a156c3d-2afd-4790-be9f-c0db10df7dde", "AQAAAAEAACcQAAAAEEGGLaQ1QzYq9kLRoUeAypTlBpXWZlLe4UsfHNE7ZCV3YB1PNb1v6A2VsBHnc/2GSg==", "5d940ab2-7165-4af1-95fd-41cfedfae5db" });
        }
    }
}
