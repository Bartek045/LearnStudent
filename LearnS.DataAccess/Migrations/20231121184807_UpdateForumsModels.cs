using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateForumsModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ForumComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 21, 19, 48, 7, 174, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 21, 19, 48, 7, 174, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 21, 19, 48, 7, 174, DateTimeKind.Local).AddTicks(800));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
