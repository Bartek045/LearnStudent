using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addNumberCommentToForumModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ForumComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 20, 9, 39, 31, 878, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 20, 9, 39, 31, 878, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 20, 9, 39, 31, 878, DateTimeKind.Local).AddTicks(2626));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ForumComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 20, 9, 32, 49, 311, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 20, 9, 32, 49, 311, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 20, 9, 32, 49, 309, DateTimeKind.Local).AddTicks(5018));
        }
    }
}
