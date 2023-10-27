using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addQuizToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quiz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnswerI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnswerII = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnswerIII = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnswerIV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quiz", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quiz_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Quiz",
                columns: new[] { "Id", "AnswerI", "AnswerII", "AnswerIII", "AnswerIV", "IsCorrect", "Question", "SectionId", "Title" },
                values: new object[] { 1, "2", "3", "4", "5", false, " ile to 2 + 2", 2, "Quiz matematyka" });

            migrationBuilder.CreateIndex(
                name: "IX_Quiz_SectionId",
                table: "Quiz",
                column: "SectionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quiz");
        }
    }
}
