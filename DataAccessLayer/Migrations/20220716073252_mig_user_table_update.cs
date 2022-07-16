using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_user_table_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SocialMedias",
                newName: "SocialMediaId");

            migrationBuilder.AddColumn<int>(
                name: "SocialMediaId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_SocialMediaId",
                table: "Users",
                column: "SocialMediaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_SocialMedias_SocialMediaId",
                table: "Users",
                column: "SocialMediaId",
                principalTable: "SocialMedias",
                principalColumn: "SocialMediaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_SocialMedias_SocialMediaId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SocialMediaId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SocialMediaId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "SocialMediaId",
                table: "SocialMedias",
                newName: "Id");
        }
    }
}
