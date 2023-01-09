using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Web.Data.Migrations
{
    public partial class AddedNewQuantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "LeaveRequests",
                type: "int",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "898c75aa-a8a3-4b06-a1b9-e2decce0c8ab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "b3acb58b-ac7d-46e5-8d0e-e8b85334157e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40232b94-2c16-4e72-8318-92e1fc8daaa5", "AQAAAAEAACcQAAAAEE3WFZ8ehkgByxy3OMWpVQysZsV6rsMUloMBrw97D7/lRo7WKbIeIOPN8jfAX3A3Ww==", "72cbde31-8894-4549-87d0-824631f22bec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b7e1ea9-a91c-4a73-9b80-3dd51c70d561", "AQAAAAEAACcQAAAAEHUWGZvAHHX7Hp03osLVT93PsIeFq/gmIbXTIWjPByVsop2gY7M2sy4V115lWTAMvg==", "2828dbe5-15eb-4a35-9fd3-ffed421abb9b" });
        }
    }
}
