using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleBookingRentalApp.Migrations
{
    public partial class M010520242045 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingAdditionalDrivers_Persons_AdditionalDriverId",
                table: "BookingAdditionalDrivers");

            migrationBuilder.DropIndex(
                name: "IX_BookingAdditionalDrivers_AdditionalDriverId",
                table: "BookingAdditionalDrivers");

            migrationBuilder.DropColumn(
                name: "AdditionalDriverId",
                table: "BookingAdditionalDrivers");

            migrationBuilder.AddColumn<bool>(
                name: "AdditionalDriver",
                table: "Persons",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PersonId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PersonId",
                table: "Persons",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Persons_PersonId",
                table: "Persons",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Persons_PersonId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_PersonId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "AdditionalDriver",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Persons");

            migrationBuilder.AddColumn<Guid>(
                name: "AdditionalDriverId",
                table: "BookingAdditionalDrivers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookingAdditionalDrivers_AdditionalDriverId",
                table: "BookingAdditionalDrivers",
                column: "AdditionalDriverId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingAdditionalDrivers_Persons_AdditionalDriverId",
                table: "BookingAdditionalDrivers",
                column: "AdditionalDriverId",
                principalTable: "Persons",
                principalColumn: "Id");
        }
    }
}
