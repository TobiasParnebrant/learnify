using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class PaymentIntentAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "167efcec-c712-4de2-af70-ed1126b26d9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9f19264-6c69-4cad-8aa9-9f494d0f921a");

            migrationBuilder.AddColumn<string>(
                name: "ClientSecret",
                table: "Basket",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentIntentId",
                table: "Basket",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "77c15426-0ec6-4d53-9786-73550f9a6d8b", "19e36243-36ec-4aca-b753-d70afecf6182", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "02bc63ed-8e10-41c2-912d-485fcb282200", "c16eaa20-b297-40ff-8293-894038c9ec60", "Instructor", "INSTRUCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02bc63ed-8e10-41c2-912d-485fcb282200");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77c15426-0ec6-4d53-9786-73550f9a6d8b");

            migrationBuilder.DropColumn(
                name: "ClientSecret",
                table: "Basket");

            migrationBuilder.DropColumn(
                name: "PaymentIntentId",
                table: "Basket");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "167efcec-c712-4de2-af70-ed1126b26d9d", "acabecf1-56d4-473f-afa3-55c7ce474d93", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9f19264-6c69-4cad-8aa9-9f494d0f921a", "66a3606b-7737-444c-91a8-6c5c8455c663", "Instructor", "INSTRUCTOR" });
        }
    }
}
