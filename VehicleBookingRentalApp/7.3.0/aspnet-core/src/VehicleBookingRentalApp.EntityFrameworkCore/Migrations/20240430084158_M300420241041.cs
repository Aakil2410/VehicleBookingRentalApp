using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleBookingRentalApp.Migrations
{
    public partial class M300420241041 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Persons_AdditionalDriverId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Bookings_BookingId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Persons_PersonId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_BookingId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_PersonId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Persons");

            migrationBuilder.CreateTable(
                name: "AdditionalDrivers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalDrivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalDrivers_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdditionalDrivers_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdditionalDrivers_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalDrivers_BookingId",
                table: "AdditionalDrivers",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalDrivers_PersonId",
                table: "AdditionalDrivers",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalDrivers_UserId",
                table: "AdditionalDrivers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_AdditionalDrivers_AdditionalDriverId",
                table: "Documents",
                column: "AdditionalDriverId",
                principalTable: "AdditionalDrivers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_AdditionalDrivers_AdditionalDriverId",
                table: "Documents");

            migrationBuilder.DropTable(
                name: "AdditionalDrivers");

            migrationBuilder.AddColumn<Guid>(
                name: "BookingId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PersonId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_BookingId",
                table: "Persons",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PersonId",
                table: "Persons",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Persons_AdditionalDriverId",
                table: "Documents",
                column: "AdditionalDriverId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Bookings_BookingId",
                table: "Persons",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Persons_PersonId",
                table: "Persons",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }
    }
}
