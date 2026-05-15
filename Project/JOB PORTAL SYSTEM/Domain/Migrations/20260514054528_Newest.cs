using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
<<<<<<<< HEAD:Project/JOB PORTAL SYSTEM/Domain/Migrations/20260514083233_hiiiiii.cs
    public partial class hiiiiii : Migration
========
    public partial class Newest : Migration
>>>>>>>> f3440fd38c67e6901e6c39652dd70e36101788fc:Project/JOB PORTAL SYSTEM/Domain/Migrations/20260514054528_Newest.cs
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "SignupRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "SignupRequests");
        }
    }
}
