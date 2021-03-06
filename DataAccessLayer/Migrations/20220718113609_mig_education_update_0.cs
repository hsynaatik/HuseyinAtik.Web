using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_education_update_0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Education_EducationId",
                table: "WorkExperiences");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropIndex(
                name: "IX_WorkExperiences_EducationId",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "WorkExperiences");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "WorkExperiences",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    EducationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationFinishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EducationStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EducationStatus = table.Column<bool>(type: "bit", nullable: false),
                    EducationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.EducationId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_EducationId",
                table: "WorkExperiences",
                column: "EducationId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Education_EducationId",
                table: "WorkExperiences",
                column: "EducationId",
                principalTable: "Education",
                principalColumn: "EducationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
