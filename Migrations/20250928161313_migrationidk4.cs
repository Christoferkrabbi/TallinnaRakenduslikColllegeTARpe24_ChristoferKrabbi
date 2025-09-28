using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TallinnaRakenduslikColllegeTARpe24_ChristoferKrabbi.Migrations
{
    /// <inheritdoc />
    public partial class migrationidk4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Personality",
                table: "Departments");

            migrationBuilder.AlterColumn<decimal>(
                name: "MonthlyRevenue",
                table: "Departments",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Revenue");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "MonthlyRevenue",
                table: "Departments",
                type: "Revenue",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "Personality",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
