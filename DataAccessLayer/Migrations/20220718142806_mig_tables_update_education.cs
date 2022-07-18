using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_tables_update_education : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    EducationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EducationFinishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EducationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EducationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Educations");
        }
    }
}
