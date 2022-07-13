using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Web.Data.Migrations
{
    public partial class AddingPeriodAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "09c4a358-a099-403f-8ffc-c95df0ed4fd3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "5524f7e9-7024-422c-a63a-68b392da2e36");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e051552-2822-4f76-850c-69217b6bcc22", "AQAAAAEAACcQAAAAEHiL4v9dRvAnjA0P8vhDl+0RiM23mfTcdD5HP5oUVPsM1W7jt2Vzml17Xwj9taxDRQ==", "9e2baca2-cf1e-41a6-b2c8-2ec6561ae67c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "805c4144-de7b-4449-b778-84d31b651703", "AQAAAAEAACcQAAAAEGeIWYlQjipzsVRaxybjXEr9PSWqHjOdmD2FeDspHZLhx04YYLfVhXWxWJobfvAlyg==", "0b6252e6-4d6c-4fea-9d59-7bdef26e423f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "d6109eff-b0f6-452a-9a50-dca373a822b2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "8cb6f6ad-8560-41c3-abea-aa28814ef61e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7335585a-1cea-4e49-a326-e626848b6afd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3154fde8-27b8-4e48-acd7-4ec1725eddfc", "AQAAAAEAACcQAAAAEPjO3DrFLzrHhelXUp2QTwNwozNt7/a2KZ/ktIj89HuwZEgc2y/h20ZcDl7KKJp9ow==", "dda109b3-6bf6-4da7-9e14-368666e87c80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0eab64d-0036-4a8c-8faf-dd9c3951abc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bf66e09-903f-4522-a7da-6745e1e00fbf", "AQAAAAEAACcQAAAAEHreLX8Wk5/KxDrndyisBRDTP/6qrATlpmxLWH4gUTQoZmB4KeKYixFj0bZwcZMOFw==", "a904d324-4aeb-4efb-aa06-59186f75bca2" });
        }
    }
}
