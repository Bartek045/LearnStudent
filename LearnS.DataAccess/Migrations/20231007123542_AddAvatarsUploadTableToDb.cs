using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAvatarsUploadTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AvatarsUploads",
                keyColumn: "Id",
                keyValue: 1,
                column: "Display",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AvatarsUploads",
                keyColumn: "Id",
                keyValue: 2,
                column: "Display",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AvatarsUploads",
                keyColumn: "Id",
                keyValue: 1,
                column: "Display",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AvatarsUploads",
                keyColumn: "Id",
                keyValue: 2,
                column: "Display",
                value: 0);
        }
    }
}
