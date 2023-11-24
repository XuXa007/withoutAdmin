using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication7.Migrations
{
    /// <inheritdoc />
    public partial class Test3Mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceReport_Vehicle_VehicleId",
                table: "MaintenanceReport");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "MaintenanceReport",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceReport_Vehicle_VehicleId",
                table: "MaintenanceReport",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceReport_Vehicle_VehicleId",
                table: "MaintenanceReport");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "MaintenanceReport",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceReport_Vehicle_VehicleId",
                table: "MaintenanceReport",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
