using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp3.Migrations.ApplicationUserDb
{
    public partial class MyDataBase2InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fanfic_AspNetUsers_ApplicationUserId",
                table: "Fanfic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fanfic",
                table: "Fanfic");

            migrationBuilder.RenameTable(
                name: "Fanfic",
                newName: "Fanfics");

            migrationBuilder.RenameIndex(
                name: "IX_Fanfic_ApplicationUserId",
                table: "Fanfics",
                newName: "IX_Fanfics_ApplicationUserId");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Fanfics",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fanfics",
                table: "Fanfics",
                column: "FanficId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fanfics_AspNetUsers_ApplicationUserId",
                table: "Fanfics",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fanfics_AspNetUsers_ApplicationUserId",
                table: "Fanfics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fanfics",
                table: "Fanfics");

            migrationBuilder.RenameTable(
                name: "Fanfics",
                newName: "Fanfic");

            migrationBuilder.RenameIndex(
                name: "IX_Fanfics_ApplicationUserId",
                table: "Fanfic",
                newName: "IX_Fanfic_ApplicationUserId");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Fanfic",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fanfic",
                table: "Fanfic",
                column: "FanficId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fanfic_AspNetUsers_ApplicationUserId",
                table: "Fanfic",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
