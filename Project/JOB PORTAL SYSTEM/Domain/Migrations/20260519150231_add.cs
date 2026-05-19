using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerQualifications_JobSeekers_JobSeekerId",
                table: "JobSeekerQualifications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerQualifications_Qualifications_QualificationId",
                table: "JobSeekerQualifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSeekerQualifications",
                table: "JobSeekerQualifications");

            migrationBuilder.RenameTable(
                name: "JobSeekerQualifications",
                newName: "JobSeekerQualification");

            migrationBuilder.RenameIndex(
                name: "IX_JobSeekerQualifications_QualificationId",
                table: "JobSeekerQualification",
                newName: "IX_JobSeekerQualification_QualificationId");

            migrationBuilder.RenameIndex(
                name: "IX_JobSeekerQualifications_JobSeekerId",
                table: "JobSeekerQualification",
                newName: "IX_JobSeekerQualification_JobSeekerId");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "SignupRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSeekerQualification",
                table: "JobSeekerQualification",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerQualification_JobSeekers_JobSeekerId",
                table: "JobSeekerQualification",
                column: "JobSeekerId",
                principalTable: "JobSeekers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerQualification_Qualifications_QualificationId",
                table: "JobSeekerQualification",
                column: "QualificationId",
                principalTable: "Qualifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerQualification_JobSeekers_JobSeekerId",
                table: "JobSeekerQualification");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerQualification_Qualifications_QualificationId",
                table: "JobSeekerQualification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSeekerQualification",
                table: "JobSeekerQualification");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "SignupRequests");

            migrationBuilder.RenameTable(
                name: "JobSeekerQualification",
                newName: "JobSeekerQualifications");

            migrationBuilder.RenameIndex(
                name: "IX_JobSeekerQualification_QualificationId",
                table: "JobSeekerQualifications",
                newName: "IX_JobSeekerQualifications_QualificationId");

            migrationBuilder.RenameIndex(
                name: "IX_JobSeekerQualification_JobSeekerId",
                table: "JobSeekerQualifications",
                newName: "IX_JobSeekerQualifications_JobSeekerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSeekerQualifications",
                table: "JobSeekerQualifications",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerQualifications_JobSeekers_JobSeekerId",
                table: "JobSeekerQualifications",
                column: "JobSeekerId",
                principalTable: "JobSeekers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerQualifications_Qualifications_QualificationId",
                table: "JobSeekerQualifications",
                column: "QualificationId",
                principalTable: "Qualifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
