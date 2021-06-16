using Microsoft.EntityFrameworkCore.Migrations;

namespace apppracticando.Migrations
{
    public partial class inicial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fail_Comentarios_ComentarioId",
                table: "Fail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fail",
                table: "Fail");

            migrationBuilder.RenameTable(
                name: "Fail",
                newName: "Fails");

            migrationBuilder.RenameIndex(
                name: "IX_Fail_ComentarioId",
                table: "Fails",
                newName: "IX_Fails_ComentarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fails",
                table: "Fails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fails_Comentarios_ComentarioId",
                table: "Fails",
                column: "ComentarioId",
                principalTable: "Comentarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fails_Comentarios_ComentarioId",
                table: "Fails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fails",
                table: "Fails");

            migrationBuilder.RenameTable(
                name: "Fails",
                newName: "Fail");

            migrationBuilder.RenameIndex(
                name: "IX_Fails_ComentarioId",
                table: "Fail",
                newName: "IX_Fail_ComentarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fail",
                table: "Fail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fail_Comentarios_ComentarioId",
                table: "Fail",
                column: "ComentarioId",
                principalTable: "Comentarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
