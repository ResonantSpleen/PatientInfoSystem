using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientInfoSystem.Migrations
{
    public partial class addedKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Patients_PatientIdId",
                table: "Visits");

            migrationBuilder.DropIndex(
                name: "IX_Visits_PatientIdId",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "PatientIdId",
                table: "Visits");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Visits",
                newName: "VisitId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Patients",
                newName: "PatientId");

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Visits",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Visits_PatientId",
                table: "Visits",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Patients_PatientId",
                table: "Visits",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Patients_PatientId",
                table: "Visits");

            migrationBuilder.DropIndex(
                name: "IX_Visits_PatientId",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Visits");

            migrationBuilder.RenameColumn(
                name: "VisitId",
                table: "Visits",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "Patients",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "PatientIdId",
                table: "Visits",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Visits_PatientIdId",
                table: "Visits",
                column: "PatientIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Patients_PatientIdId",
                table: "Visits",
                column: "PatientIdId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
