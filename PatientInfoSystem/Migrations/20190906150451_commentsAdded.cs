using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientInfoSystem.Migrations
{
    public partial class commentsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Study_Patients_PatientId",
                table: "Study");

            migrationBuilder.DropIndex(
                name: "IX_Study_PatientId",
                table: "Study");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Study");

            migrationBuilder.DropColumn(
                name: "AlsType",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Study",
                newName: "StudyName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Study",
                newName: "StudyId");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Patients",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PatientStudy",
                columns: table => new
                {
                    PatientStudyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PatientId = table.Column<int>(nullable: false),
                    StudyId = table.Column<int>(nullable: true),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientStudy", x => x.PatientStudyId);
                    table.ForeignKey(
                        name: "FK_PatientStudy_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientStudy_Study_StudyId",
                        column: x => x.StudyId,
                        principalTable: "Study",
                        principalColumn: "StudyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientStudy_PatientId",
                table: "PatientStudy",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientStudy_StudyId",
                table: "PatientStudy",
                column: "StudyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientStudy");

            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "StudyName",
                table: "Study",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "StudyId",
                table: "Study",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Study",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Patients",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "AlsType",
                table: "Patients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Study_PatientId",
                table: "Study",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Study_Patients_PatientId",
                table: "Study",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
