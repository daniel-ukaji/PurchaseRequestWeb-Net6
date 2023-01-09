using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Web.Data.Migrations
{
    public partial class AddedNewRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "38f559f6-054d-41ed-9ac9-b16a3bcaa246");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "88535def-5639-4a91-be80-0e06601e42a4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c9e8e68-d101-4c50-8641-d50a6a8e2385", "AQAAAAEAACcQAAAAEALQIZq0+ZoXdeYCKr0PwFTrJmgQ4h2KoUqnx7tMAa51lQHWcd4QuAi+2VCEm57SIw==", "75326da7-6f5d-4f1d-8cc8-980e9382e116" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c772ea0-7e2c-457d-aecb-7e96f814a945", "AQAAAAEAACcQAAAAEATbfC2+jHUpePbsI/8e2dePrrypJyHfC3Pu4B0AjrhGkmew4zLeZDQbk7AbjOVxfA==", "33477612-9cb8-4bb5-b36a-b0e0f0717e82" });
        }
    }
}
