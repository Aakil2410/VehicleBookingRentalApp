using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleBookingRentalApp.Migrations
{
    public partial class M010520241154 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookedVehicles");

            migrationBuilder.CreateTable(
                name: "BookingAdditionalDrivers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AdditionalDriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_BookingAdditionalDrivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingAdditionalDrivers_AdditionalDrivers_AdditionalDriverId",
                        column: x => x.AdditionalDriverId,
                        principalTable: "AdditionalDrivers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookingAdditionalDrivers_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookingRentalAddons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RentalAddonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_BookingRentalAddons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingRentalAddons_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookingRentalAddons_RentalAddons_RentalAddonId",
                        column: x => x.RentalAddonId,
                        principalTable: "RentalAddons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingAdditionalDrivers_AdditionalDriverId",
                table: "BookingAdditionalDrivers",
                column: "AdditionalDriverId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingAdditionalDrivers_BookingId",
                table: "BookingAdditionalDrivers",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingRentalAddons_BookingId",
                table: "BookingRentalAddons",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingRentalAddons_RentalAddonId",
                table: "BookingRentalAddons",
                column: "RentalAddonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingAdditionalDrivers");

            migrationBuilder.DropTable(
                name: "BookingRentalAddons");

            migrationBuilder.CreateTable(
                name: "BookedVehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookedVehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookedVehicles_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookedVehicles_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookedVehicles_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookedVehicles_BookingId",
                table: "BookedVehicles",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedVehicles_PersonId",
                table: "BookedVehicles",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedVehicles_VehicleId",
                table: "BookedVehicles",
                column: "VehicleId");
        }
    }
}
