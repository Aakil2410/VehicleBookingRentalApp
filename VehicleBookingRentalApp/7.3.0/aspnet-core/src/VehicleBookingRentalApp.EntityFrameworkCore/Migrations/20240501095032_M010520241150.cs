using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleBookingRentalApp.Migrations
{
    public partial class M010520241150 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalDrivers_AbpUsers_UserId",
                table: "AdditionalDrivers");

            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalDrivers_Persons_PersonId",
                table: "AdditionalDrivers");

            migrationBuilder.DropForeignKey(
                name: "FK_RentalAddons_Bookings_BookingId",
                table: "RentalAddons");

            migrationBuilder.DropIndex(
                name: "IX_RentalAddons_BookingId",
                table: "RentalAddons");

            migrationBuilder.DropIndex(
                name: "IX_AdditionalDrivers_PersonId",
                table: "AdditionalDrivers");

            migrationBuilder.DropIndex(
                name: "IX_AdditionalDrivers_UserId",
                table: "AdditionalDrivers");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "RentalAddons");

            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "AdditionalDrivers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "AdditionalDrivers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AdditionalDrivers");

            migrationBuilder.DropColumn(
                name: "IDNumber",
                table: "AdditionalDrivers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AdditionalDrivers");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "AdditionalDrivers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "AdditionalDrivers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AdditionalDrivers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BookingId",
                table: "RentalAddons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactNumber",
                table: "AdditionalDrivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "AdditionalDrivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AdditionalDrivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IDNumber",
                table: "AdditionalDrivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AdditionalDrivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PersonId",
                table: "AdditionalDrivers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "AdditionalDrivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "AdditionalDrivers",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RentalAddons_BookingId",
                table: "RentalAddons",
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
                name: "FK_AdditionalDrivers_AbpUsers_UserId",
                table: "AdditionalDrivers",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalDrivers_Persons_PersonId",
                table: "AdditionalDrivers",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RentalAddons_Bookings_BookingId",
                table: "RentalAddons",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id");
        }
    }
}
