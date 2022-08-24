using Microsoft.EntityFrameworkCore.Migrations;

namespace Asm1670.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Customer");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Book",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c9c2b70c-9105-439c-baf8-2d2076b37fcd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "42c3b854-5c7a-4846-b2f7-f323a8cfa2fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "762adbd0-b800-44f0-aa45-c80943e2dfee", "Store Owner", "Store Owner" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "3", "3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4431cf4-0298-42fd-834b-8b175d784414", "AQAAAAEAACcQAAAAEKa5jhqYT8WVngxBioNTnAPFFuNoJjkfsQVTKLM+VPHTPbIIwNEYkL7yiIlxE5tiug==", "fa1c29d2-6963-404f-aafd-889e91913c85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35770888-0f5a-4bc0-86d1-a514bc639523", "AQAAAAEAACcQAAAAEA3MADEmV28IbO5lSOl9nBhzUdO0HFRHc6FsHmNGWC7n+/TmyKpJuARH8Ci/V3XZzg==", "20edb7d8-5e20-4b22-8962-c85c52154820" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93aa79d8-7042-482f-9936-584e565752e4", "AQAAAAEAACcQAAAAEJG8Imz5KVHzlJvfIjAxiZn18JRe4ml2kEK0DFjPh/UiUJyAGSqFJ54iDnhjoI1SJA==", "0a99694a-9e78-4b29-9476-733279378fe5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3", "3" });

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Book");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "63436140-419e-441e-857d-3747025498d2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2dcf901a-a1ee-4d0b-81c9-ff6f16f4ad1e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59ae3664-5491-4fd1-a80b-15afedd731fe", "StoreOwner", "StoreOwner" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7958cb62-eab1-4fd8-8d4c-a219f5a91b2d", "AQAAAAEAACcQAAAAEJR7hXsHTgFbwq0g4Jp+FHtB4LkI2w0Va3h7lNhtq/CK7IH40lUMYq9cnfg04eDBtg==", "3f6ad098-32ff-4161-a447-9f2e98f72892" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94e6e0d5-455e-4a21-b6b0-3ffa90ff78d9", "AQAAAAEAACcQAAAAEJsx4mye7A2L2B0KLkYjnijasAIkCArfS7zqecwn0hYIsY6oRLbELbzOUSZGDVg4hg==", "1152b80d-e2bc-4cbd-82e5-5b96c12e5b2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66897488-ba79-4dc3-b861-62ceca4128f1", "AQAAAAEAACcQAAAAEHdBq+vp6bd+HfP/wA6O7IaKdT0G8uyaFg1JcmX/v4BuA5evHpWtKB0tjCxYZknx6A==", "275b2c33-6718-4701-be64-7ad7bce59c97" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "Phone" },
                values: new object[] { 20, "0843034237" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "Phone" },
                values: new object[] { 20, "0843034237" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "Phone" },
                values: new object[] { 20, "0843034237" });
        }
    }
}
