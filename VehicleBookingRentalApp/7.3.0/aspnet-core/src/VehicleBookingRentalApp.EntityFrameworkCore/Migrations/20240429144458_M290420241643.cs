using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleBookingRentalApp.Migrations
{
    public partial class M290420241643 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_RentalAddons_RentalAddonId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_RentalAddonId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "RentalAddonId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "RentalPeriod",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "VehicleAvailability",
                table: "Vehicles",
                newName: "VehicleStatus");

            migrationBuilder.RenameColumn(
                name: "RentalPrice",
                table: "Vehicles",
                newName: "BaseRentalPrice");

            migrationBuilder.AddColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VIN",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BookingId",
                table: "RentalAddons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Credit",
                table: "Persons",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Valid",
                table: "Documents",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RentalAddons_BookingId",
                table: "RentalAddons",
                column: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_RentalAddons_Bookings_BookingId",
                table: "RentalAddons",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentalAddons_Bookings_BookingId",
                table: "RentalAddons");

            migrationBuilder.DropIndex(
                name: "IX_RentalAddons_BookingId",
                table: "RentalAddons");

            migrationBuilder.DropColumn(
                name: "LicensePlateNumber",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "VIN",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "RentalAddons");

            migrationBuilder.DropColumn(
                name: "Credit",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Valid",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "VehicleStatus",
                table: "Vehicles",
                newName: "VehicleAvailability");

            migrationBuilder.RenameColumn(
                name: "BaseRentalPrice",
                table: "Vehicles",
                newName: "RentalPrice");

            migrationBuilder.AddColumn<Guid>(
                name: "RentalAddonId",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RentalPeriod",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RentalAddonId",
                table: "Bookings",
                column: "RentalAddonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_RentalAddons_RentalAddonId",
                table: "Bookings",
                column: "RentalAddonId",
                principalTable: "RentalAddons",
                principalColumn: "Id");
        }
    }
}
