using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Web.Data.Migrations
{
    public partial class AddedNewModelPurchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Model",
                table: "LeaveRequests",
                newName: "ModelPurchase");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModelPurchase",
                table: "LeaveRequests",
                newName: "Model");

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
    }
}
