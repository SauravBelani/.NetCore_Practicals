using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Practical_16.Data.Migrations
{
    public partial class addinguserrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "094afa8c-69e3-4103-a542-8aee12940f9a", "a1776e12-3359-43cc-9716-066f0c1e1679", "Admin", "ADMIN" },
                    { "9f074bba-372c-474e-81a2-92e877a73075", "d621317b-ef46-4e39-a820-587cc85860e4", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfjoined", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MobileNumber", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5b2546a3-3e7a-454e-ac18-52d4cae97b2f", 0, "984a02ff-5d1e-4e71-8df7-55914ec2ba2d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin23@gmail.com", true, "Saurav", "Belani", false, null, null, "ADMIN23@GMAIL.COM", "ADMIN23@GMAIL.COM", "AQAAAAEAACcQAAAAEIOA7De0SA/B/mbDRzfA4HjKwOKRZiYOS3EiaOP6eJJTnBdSrKENodDxGKUk951J+A==", null, false, "d217419b-0d89-44d1-8920-ba92d06519a7", false, "admin23@gmail.com" },
                    { "4b2546a3-3e7a-424e-ac18-52d4cae97b2f", 0, "f14f135b-0ba6-44d9-908c-9c82637bfff0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "system", "user", false, null, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEInwv9SeXYl0idQbwqvMRLvmcjUg9+PvYAGKTd81Jb/85gtYkkUoAC/1yQE0Yjoj7A==", null, false, "1f5208d0-0205-4742-bed1-f3ecae7c633d", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "094afa8c-69e3-4103-a542-8aee12940f9a", "5b2546a3-3e7a-454e-ac18-52d4cae97b2f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9f074bba-372c-474e-81a2-92e877a73075", "4b2546a3-3e7a-424e-ac18-52d4cae97b2f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9f074bba-372c-474e-81a2-92e877a73075", "4b2546a3-3e7a-424e-ac18-52d4cae97b2f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "094afa8c-69e3-4103-a542-8aee12940f9a", "5b2546a3-3e7a-454e-ac18-52d4cae97b2f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "094afa8c-69e3-4103-a542-8aee12940f9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f074bba-372c-474e-81a2-92e877a73075");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b2546a3-3e7a-424e-ac18-52d4cae97b2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b2546a3-3e7a-454e-ac18-52d4cae97b2f");
        }
    }
}
