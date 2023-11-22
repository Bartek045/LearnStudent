using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateForumsModelsaddNumberOfViews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfViews",
                table: "ForumThreads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ForumComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 21, 20, 29, 13, 992, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 21, 20, 29, 13, 992, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "NumberOfViews" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 29, 13, 992, DateTimeKind.Local).AddTicks(9636), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfViews",
                table: "ForumThreads");

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
    }
}
