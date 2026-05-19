using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class gg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekers_AuthUsers_AuthUserId",
                table: "JobSeekers");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualifications_JobSeekers_JobSeekerId",
                table: "Qualifications");

            migrationBuilder.DropIndex(
                name: "IX_Qualifications_JobSeekerId",
                table: "Qualifications");

            migrationBuilder.DropIndex(
                name: "IX_JobSeekers_AuthUserId",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "JobSeekerId",
                table: "Qualifications");

            migrationBuilder.DropColumn(
                name: "AuthUserId",
                table: "JobSeekers");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekers_UserId",
                table: "JobSeekers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekers_AuthUsers_UserId",
                table: "JobSeekers",
                column: "UserId",
                principalTable: "AuthUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekers_AuthUsers_UserId",
                table: "JobSeekers");

            migrationBuilder.DropIndex(
                name: "IX_JobSeekers_UserId",
                table: "JobSeekers");

            migrationBuilder.AddColumn<Guid>(
                name: "JobSeekerId",
                table: "Qualifications",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AuthUserId",
                table: "JobSeekers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Qualifications_JobSeekerId",
                table: "Qualifications",
                column: "JobSeekerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekers_AuthUserId",
                table: "JobSeekers",
                column: "AuthUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekers_AuthUsers_AuthUserId",
                table: "JobSeekers",
                column: "AuthUserId",
                principalTable: "AuthUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Qualifications_JobSeekers_JobSeekerId",
                table: "Qualifications",
                column: "JobSeekerId",
                principalTable: "JobSeekers",
                principalColumn: "Id");
        }
    }
}
