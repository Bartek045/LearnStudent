using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addUserAvatarToUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ForumComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 1, 11, 46, 9, 993, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 1, 11, 46, 9, 993, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 1, 11, 46, 9, 993, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.InsertData(
                table: "UserAvatar",
                columns: new[] { "Id", "AvatarId", "IsLocked", "IsOwned", "UserId" },
                values: new object[] { 1, 1, true, false, "f096fef9-cdf0-4298-81b1-52925b2ef44d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserAvatar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "ForumComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 1, 11, 22, 44, 183, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 1, 11, 22, 44, 183, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 1, 11, 22, 44, 183, DateTimeKind.Local).AddTicks(1692));
        }
    }
}
