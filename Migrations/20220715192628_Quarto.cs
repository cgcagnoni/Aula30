using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aula30.Migrations
{
    public partial class Quarto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Instituição_InstituicaoId",
                table: "Alunos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos");

            migrationBuilder.RenameTable(
                name: "Alunos",
                newName: "Aluno");

            migrationBuilder.RenameIndex(
                name: "IX_Alunos_InstituicaoId",
                table: "Aluno",
                newName: "IX_Aluno_InstituicaoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Aluno",
                table: "Aluno",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Instituição_InstituicaoId",
                table: "Aluno",
                column: "InstituicaoId",
                principalTable: "Instituição",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Instituição_InstituicaoId",
                table: "Aluno");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Aluno",
                table: "Aluno");

            migrationBuilder.RenameTable(
                name: "Aluno",
                newName: "Alunos");

            migrationBuilder.RenameIndex(
                name: "IX_Aluno_InstituicaoId",
                table: "Alunos",
                newName: "IX_Alunos_InstituicaoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Instituição_InstituicaoId",
                table: "Alunos",
                column: "InstituicaoId",
                principalTable: "Instituição",
                principalColumn: "Id");
        }
    }
}
