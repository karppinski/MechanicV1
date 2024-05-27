using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changesInAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AppontmentDate",
                table: "Appointments",
                newName: "AppointmentDate");

            migrationBuilder.AddColumn<Guid>(
                name: "AddressId",
                table: "Mechanics",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Mechanics_AddressId",
                table: "Mechanics",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mechanics_Addresses_AddressId",
                table: "Mechanics",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mechanics_Addresses_AddressId",
                table: "Mechanics");

            migrationBuilder.DropIndex(
                name: "IX_Mechanics_AddressId",
                table: "Mechanics");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Mechanics");

            migrationBuilder.RenameColumn(
                name: "AppointmentDate",
                table: "Appointments",
                newName: "AppontmentDate");
        }
    }
}
