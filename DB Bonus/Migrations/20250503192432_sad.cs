using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_Bonus.Migrations
{
    /// <inheritdoc />
    public partial class sad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastDonationDate",
                table: "Donor",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "HealthStatus",
                table: "Donor",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Donor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NationaiID",
                table: "Donor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Donor",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HealthStatus",
                table: "Donor");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Donor");

            migrationBuilder.DropColumn(
                name: "NationaiID",
                table: "Donor");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Donor");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastDonationDate",
                table: "Donor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
