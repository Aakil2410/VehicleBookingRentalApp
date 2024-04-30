using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleBookingRentalApp.Migrations
{
    public partial class M300420241641 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AdditionalDrivers_AdditionalDriversId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Documents_DocumentId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_RentalAddons_RentalAddonId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Persons_PersonId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_PersonId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_AdditionalDriversId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_DocumentId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_RentalAddonId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "AdditionalDriversId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "DocumentId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "RentalAddonId",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "TotalCost",
                table: "Transactions",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Bookings",
                newName: "BookingStatus");

            migrationBuilder.AlterColumn<int>(
                name: "TransactionType",
                table: "Transactions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<Guid>(
                name: "BookingId",
                table: "RentalAddons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BookingId",
                table: "Documents",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Deposit",
                table: "Bookings",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BookingId",
                table: "AdditionalDrivers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RentalAddons_BookingId",
                table: "RentalAddons",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_BookingId",
                table: "Documents",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalDrivers_BookingId",
                table: "AdditionalDrivers",
                column: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalDrivers_Bookings_BookingId",
                table: "AdditionalDrivers",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Bookings_BookingId",
                table: "Documents",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id");

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
                name: "FK_AdditionalDrivers_Bookings_BookingId",
                table: "AdditionalDrivers");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Bookings_BookingId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_RentalAddons_Bookings_BookingId",
                table: "RentalAddons");

            migrationBuilder.DropIndex(
                name: "IX_RentalAddons_BookingId",
                table: "RentalAddons");

            migrationBuilder.DropIndex(
                name: "IX_Documents_BookingId",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_AdditionalDrivers_BookingId",
                table: "AdditionalDrivers");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "RentalAddons");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "Deposit",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "AdditionalDrivers");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Transactions",
                newName: "TotalCost");

            migrationBuilder.RenameColumn(
                name: "BookingStatus",
                table: "Bookings",
                newName: "Status");

            migrationBuilder.AlterColumn<int>(
                name: "TransactionType",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PersonId",
                table: "Transactions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AdditionalDriversId",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DocumentId",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RentalAddonId",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PersonId",
                table: "Transactions",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_AdditionalDriversId",
                table: "Bookings",
                column: "AdditionalDriversId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_DocumentId",
                table: "Bookings",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RentalAddonId",
                table: "Bookings",
                column: "RentalAddonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AdditionalDrivers_AdditionalDriversId",
                table: "Bookings",
                column: "AdditionalDriversId",
                principalTable: "AdditionalDrivers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Documents_DocumentId",
                table: "Bookings",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_RentalAddons_RentalAddonId",
                table: "Bookings",
                column: "RentalAddonId",
                principalTable: "RentalAddons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Persons_PersonId",
                table: "Transactions",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }
    }
}
