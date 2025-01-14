using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateAPI.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "RealEstate");

            migrationBuilder.CreateTable(
                name: "Apartments",
                schema: "RealEstate",
                columns: table => new
                {
                    ApartmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Rent = table.Column<decimal>(type: "numeric", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    OwnerName = table.Column<string>(type: "text", nullable: false),
                    SizeInSqft = table.Column<int>(type: "integer", nullable: false),
                    NumberOfBeds = table.Column<int>(type: "integer", nullable: false),
                    NumberOfBathrooms = table.Column<int>(type: "integer", nullable: false),
                    DistanceToSchool = table.Column<int>(type: "integer", nullable: false),
                    DistanceToBusStop = table.Column<int>(type: "integer", nullable: false),
                    DistanceToRestaurant = table.Column<int>(type: "integer", nullable: false),
                    Utilities = table.Column<string>(type: "text", nullable: false),
                    PetPolicy = table.Column<string>(type: "text", nullable: false),
                    PropertyFees = table.Column<string>(type: "text", nullable: true),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false),
                    Contact = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.ApartmentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apartments",
                schema: "RealEstate");
        }
    }
}
