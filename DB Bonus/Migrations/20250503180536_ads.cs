using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_Bonus.Migrations
{
    /// <inheritdoc />
    public partial class ads : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donor",
                columns: table => new
                {
                    DonorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    BloodType = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    IsEligible = table.Column<bool>(type: "bit", nullable: false),
                    LastDonationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donor", x => x.DonorID);
                });

            migrationBuilder.CreateTable(
                name: "BloodDonation",
                columns: table => new
                {
                    DonationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonorID = table.Column<int>(type: "int", nullable: false),
                    DonationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    BloodType = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodDonation", x => x.DonationID);
                    table.ForeignKey(
                        name: "FK_BloodDonation_Donor",
                        column: x => x.DonorID,
                        principalTable: "Donor",
                        principalColumn: "DonorID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BloodDonation_DonorID",
                table: "BloodDonation",
                column: "DonorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BloodDonation");

            migrationBuilder.DropTable(
                name: "Donor");
        }
    }
}
