using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleBookingRentalApp.Migrations
{
    public partial class M010520241805 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PersonId",
                table: "BookingAdditionalDrivers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PersonId",
                table: "AdditionalDrivers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookingAdditionalDrivers_PersonId",
                table: "BookingAdditionalDrivers",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalDrivers_PersonId",
                table: "AdditionalDrivers",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalDrivers_Persons_PersonId",
                table: "AdditionalDrivers",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingAdditionalDrivers_Persons_PersonId",
                table: "BookingAdditionalDrivers",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalDrivers_Persons_PersonId",
                table: "AdditionalDrivers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingAdditionalDrivers_Persons_PersonId",
                table: "BookingAdditionalDrivers");

            migrationBuilder.DropIndex(
                name: "IX_BookingAdditionalDrivers_PersonId",
                table: "BookingAdditionalDrivers");

            migrationBuilder.DropIndex(
                name: "IX_AdditionalDrivers_PersonId",
                table: "AdditionalDrivers");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "BookingAdditionalDrivers");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "AdditionalDrivers");
        }
    }
}
