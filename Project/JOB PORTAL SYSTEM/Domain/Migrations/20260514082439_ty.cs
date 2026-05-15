using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class ty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Qualifications_JobSeekers_JobSeekerId",
                table: "Qualifications");

            migrationBuilder.DropIndex(
                name: "IX_Qualifications_JobSeekerId",
                table: "Qualifications");

            migrationBuilder.DropColumn(
                name: "JobSeekerId",
                table: "Qualifications");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "JobSeekerId",
                table: "Qualifications",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Qualifications_JobSeekerId",
                table: "Qualifications",
                column: "JobSeekerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Qualifications_JobSeekers_JobSeekerId",
                table: "Qualifications",
                column: "JobSeekerId",
                principalTable: "JobSeekers",
                principalColumn: "Id");
        }
    }
}
