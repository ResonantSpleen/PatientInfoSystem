using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientInfoSystem.Migrations
{
    public partial class changingRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientStudy_Study_StudyId",
                table: "PatientStudy");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Study_StudyId",
                table: "Visits");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "PatientStudy",
                newName: "Status");

            migrationBuilder.AlterColumn<int>(
                name: "StudyId",
                table: "Visits",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudyId",
                table: "PatientStudy",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientStudy_Study_StudyId",
                table: "PatientStudy",
                column: "StudyId",
                principalTable: "Study",
                principalColumn: "StudyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Study_StudyId",
                table: "Visits",
                column: "StudyId",
                principalTable: "Study",
                principalColumn: "StudyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientStudy_Study_StudyId",
                table: "PatientStudy");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Study_StudyId",
                table: "Visits");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "PatientStudy",
                newName: "status");

            migrationBuilder.AlterColumn<int>(
                name: "StudyId",
                table: "Visits",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "StudyId",
                table: "PatientStudy",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_PatientStudy_Study_StudyId",
                table: "PatientStudy",
                column: "StudyId",
                principalTable: "Study",
                principalColumn: "StudyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Study_StudyId",
                table: "Visits",
                column: "StudyId",
                principalTable: "Study",
                principalColumn: "StudyId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
