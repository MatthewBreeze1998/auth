using Microsoft.EntityFrameworkCore.Migrations;

namespace ThAmCo.Auth.Data.Account.Migrations
{
    public partial class AddCustomerRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "account",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56b4ca14-43a0-4281-b5b7-6e73e400cf82");

            migrationBuilder.DeleteData(
                schema: "account",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3864a4f-1607-4c2f-8360-833047575c1b");

            migrationBuilder.InsertData(
                schema: "account",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName", "Descriptor" },
                values: new object[] { "f40dcf2e-aef8-4364-9cde-6a233a79cf7d", "3e2969ec-9bdb-4a25-99d2-1f3d34858758", "AppRole", "Manager", "Manager", "ThAmCo Manager" });

            migrationBuilder.InsertData(
                schema: "account",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName", "Descriptor" },
                values: new object[] { "3c3b4e49-71bd-4f8f-b7c4-9ebbac7adc14", "a03c8966-3884-4882-9d7f-090216f73025", "AppRole", "Staff", "STAFF", "ThAmCo Staff Members" });

            migrationBuilder.InsertData(
                schema: "account",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName", "Descriptor" },
                values: new object[] { "3a757cdf-6787-4b77-add4-0515eac57067", "0385c85e-f1ae-4286-b3bc-9126369694fd", "AppRole", "Customer", "CUSTOMER", "ThAmCo Customers" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "account",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a757cdf-6787-4b77-add4-0515eac57067");

            migrationBuilder.DeleteData(
                schema: "account",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c3b4e49-71bd-4f8f-b7c4-9ebbac7adc14");

            migrationBuilder.DeleteData(
                schema: "account",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f40dcf2e-aef8-4364-9cde-6a233a79cf7d");

            migrationBuilder.InsertData(
                schema: "account",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName", "Descriptor" },
                values: new object[] { "d3864a4f-1607-4c2f-8360-833047575c1b", "28cc5c9f-90b9-44c3-9450-5dd0335d7bc7", "AppRole", "Admin", "ADMIN", "ThAmCo Administrators" });

            migrationBuilder.InsertData(
                schema: "account",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName", "Descriptor" },
                values: new object[] { "56b4ca14-43a0-4281-b5b7-6e73e400cf82", "438580ab-bb4a-4f5c-bb00-49729fef9966", "AppRole", "Staff", "STAFF", "ThAmCo Staff Members" });
        }
    }
}
