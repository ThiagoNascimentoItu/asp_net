using Microsoft.EntityFrameworkCore.Migrations;

namespace mvc_efcore_2.Migrations
{
    public partial class SeedDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Alunos VALUES('Thiago','Masculino','thiago@gmail.com','08/02/1992')");
            migrationBuilder.Sql("INSERT INTO Alunos VALUES('Vinicius','Masculino','vinicius@gmail.com','02/08/1089')");
            migrationBuilder.Sql("INSERT INTO Alunos VALUES('Fernanda','Feminino','fer@gmail.com','08/02/2000')");
            migrationBuilder.Sql("INSERT INTO Alunos VALUES('Gerson','Masculino','gerson@gmail.com','08/02/1990')");
            migrationBuilder.Sql("INSERT INTO Alunos VALUES('Angel','Feminino','Angel@gmail.com','08/02/1900')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Alunos");
        }
    }
}
