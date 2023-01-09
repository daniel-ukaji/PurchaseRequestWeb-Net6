using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Web.Data.Migrations
{
    public partial class AddedNewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "2f618a49-041d-4bc4-8329-4094326b30a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "7e458fd1-819f-469f-bad3-cbfe89039b2e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9c44ecf-ac10-492d-8477-d0e1c8b18000", "AQAAAAEAACcQAAAAEKpjXZyn5RBDX3F1VZShXFvf5taxh6ikHSTZqVPPZebaUQ/jgyIQYgWU2MWCWGJgvQ==", "ea5e1d00-151b-4cf1-bd49-87b820d9aea4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87c0db3b-071d-454b-ae55-6d3ade427fda", "AQAAAAEAACcQAAAAEMhUIhfVBqxuI4cLR39gHbYgAvPcgFIiTO7PHihhOkV3KvtMU6Oft2lbBHsmBBnbbQ==", "83ef42a9-c9df-4f2b-afa6-0a2e7c6a67cf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Model",
                table: "LeaveRequests");

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
    }
}
