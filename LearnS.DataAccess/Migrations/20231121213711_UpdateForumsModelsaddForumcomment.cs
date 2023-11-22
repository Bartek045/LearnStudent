using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateForumsModelsaddForumcomment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ForumThreadId",
                table: "ForumComments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ForumComments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ForumThreadId" },
                values: new object[] { new DateTime(2023, 11, 21, 22, 37, 11, 342, DateTimeKind.Local).AddTicks(2628), null });

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 21, 22, 37, 11, 342, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 21, 22, 37, 11, 342, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.CreateIndex(
                name: "IX_ForumComments_ForumThreadId",
                table: "ForumComments",
                column: "ForumThreadId");

            migrationBuilder.AddForeignKey(
                name: "FK_ForumComments_ForumThreads_ForumThreadId",
                table: "ForumComments",
                column: "ForumThreadId",
                principalTable: "ForumThreads",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumComments_ForumThreads_ForumThreadId",
                table: "ForumComments");

            migrationBuilder.DropIndex(
                name: "IX_ForumComments_ForumThreadId",
                table: "ForumComments");

            migrationBuilder.DropColumn(
                name: "ForumThreadId",
                table: "ForumComments");

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
                column: "CreatedAt",
                value: new DateTime(2023, 11, 21, 20, 29, 13, 992, DateTimeKind.Local).AddTicks(9636));
        }
    }
}
