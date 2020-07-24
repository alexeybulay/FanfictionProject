using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp3.Migrations.ApplicationUserDb
{
    public partial class TestInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fanfics_Category_CategoryId",
                table: "Fanfics");

            migrationBuilder.DropForeignKey(
                name: "FK_FanficsTags_Fanfics_FanficId",
                table: "FanficsTags");

            migrationBuilder.DropForeignKey(
                name: "FK_FanficsTags_Tags_TagId",
                table: "FanficsTags");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Fanfics_CategoryId",
                table: "Fanfics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FanficsTags",
                table: "FanficsTags");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Fanfics");

            migrationBuilder.RenameTable(
                name: "FanficsTags",
                newName: "FanficTag");

            migrationBuilder.RenameIndex(
                name: "IX_FanficsTags_TagId",
                table: "FanficTag",
                newName: "IX_FanficTag_TagId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FanficTag",
                table: "FanficTag",
                columns: new[] { "FanficId", "TagId" });

            migrationBuilder.AddForeignKey(
                name: "FK_FanficTag_Fanfics_FanficId",
                table: "FanficTag",
                column: "FanficId",
                principalTable: "Fanfics",
                principalColumn: "FanficId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FanficTag_Tags_TagId",
                table: "FanficTag",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FanficTag_Fanfics_FanficId",
                table: "FanficTag");

            migrationBuilder.DropForeignKey(
                name: "FK_FanficTag_Tags_TagId",
                table: "FanficTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FanficTag",
                table: "FanficTag");

            migrationBuilder.RenameTable(
                name: "FanficTag",
                newName: "FanficsTags");

            migrationBuilder.RenameIndex(
                name: "IX_FanficTag_TagId",
                table: "FanficsTags",
                newName: "IX_FanficsTags_TagId");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Fanfics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FanficsTags",
                table: "FanficsTags",
                columns: new[] { "FanficId", "TagId" });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fanfics_CategoryId",
                table: "Fanfics",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fanfics_Category_CategoryId",
                table: "Fanfics",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FanficsTags_Fanfics_FanficId",
                table: "FanficsTags",
                column: "FanficId",
                principalTable: "Fanfics",
                principalColumn: "FanficId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FanficsTags_Tags_TagId",
                table: "FanficsTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
