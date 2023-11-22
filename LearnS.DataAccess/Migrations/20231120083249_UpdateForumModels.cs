using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateForumModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfViews",
                table: "ForumPosts",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CreatedAt", "NumberOfViews" },
                values: new object[] { new DateTime(2023, 11, 20, 9, 32, 49, 311, DateTimeKind.Local).AddTicks(4723), 0 });

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 20, 9, 32, 49, 309, DateTimeKind.Local).AddTicks(5018));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfViews",
                table: "ForumPosts");

            migrationBuilder.UpdateData(
                table: "ForumComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 17, 20, 30, 56, 115, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 17, 20, 30, 56, 115, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 17, 20, 30, 56, 115, DateTimeKind.Local).AddTicks(5840));
        }
    }
}
