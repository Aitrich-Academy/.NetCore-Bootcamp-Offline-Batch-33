using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class six : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_AuthUsers_AuthUserId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Industries_IndustryId",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "AuthUserId",
                table: "Companies",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_AuthUserId",
                table: "Companies",
                newName: "IX_Companies_UserId");

            migrationBuilder.AlterColumn<Guid>(
                name: "LocationId",
                table: "Companies",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "IndustryId",
                table: "Companies",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "JobProviders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompanyRole = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobProviders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobProviders_AuthUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AuthUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobProviders_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SignupRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignupRequests", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobProviders_CompanyId",
                table: "JobProviders",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobProviders_UserId",
                table: "JobProviders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_AuthUsers_UserId",
                table: "Companies",
                column: "UserId",
                principalTable: "AuthUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Industries_IndustryId",
                table: "Companies",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_AuthUsers_UserId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Industries_IndustryId",
                table: "Companies");

            migrationBuilder.DropTable(
                name: "JobProviders");

            migrationBuilder.DropTable(
                name: "SignupRequests");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Companies",
                newName: "AuthUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_UserId",
                table: "Companies",
                newName: "IX_Companies_AuthUserId");

            migrationBuilder.AlterColumn<Guid>(
                name: "LocationId",
                table: "Companies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IndustryId",
                table: "Companies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_AuthUsers_AuthUserId",
                table: "Companies",
                column: "AuthUserId",
                principalTable: "AuthUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Industries_IndustryId",
                table: "Companies",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
