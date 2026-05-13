using System;
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
            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "SignupRequests",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "SignupRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "JobProviders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "AuthUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_SignupRequests_CompanyId",
                table: "SignupRequests",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobProviders_CompanyId",
                table: "JobProviders",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobProviders_Companies_CompanyId",
                table: "JobProviders",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SignupRequests_Companies_CompanyId",
                table: "SignupRequests",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobProviders_Companies_CompanyId",
                table: "JobProviders");

            migrationBuilder.DropForeignKey(
                name: "FK_SignupRequests_Companies_CompanyId",
                table: "SignupRequests");

            migrationBuilder.DropIndex(
                name: "IX_SignupRequests_CompanyId",
                table: "SignupRequests");

            migrationBuilder.DropIndex(
                name: "IX_JobProviders_CompanyId",
                table: "JobProviders");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "SignupRequests");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "SignupRequests");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "JobProviders");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "AuthUsers");
        }
    }
}
