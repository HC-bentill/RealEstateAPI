using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAPI.Models
{
public class Apartment
{
    public Guid ApartmentId { get; set; }  // Unique identifier for the apartment
    public required string Title { get; set; }  // e.g., "Beautiful Apartment"
    public required string Address { get; set; }  // e.g., "1234 Broadway St"
    public required decimal Rent { get; set; }  // e.g., 1200
    public required string Description { get; set; }  // e.g., "Future alike hill pull picture swim magic..."
    public required string OwnerName { get; set; }  // e.g., "John Doe"
    public required int SizeInSqft { get; set; }  // e.g., 80 sqft
    public required int NumberOfBeds { get; set; }  // e.g., 2 beds
    public required int NumberOfBathrooms { get; set; }  // e.g., 1 bathroom
    public required int DistanceToSchool { get; set; }  // e.g., 250m
    public required int DistanceToBusStop { get; set; }  // e.g., 100m
    public required int DistanceToRestaurant { get; set; }  // e.g., 200m

    // Policy Information
    public required string Utilities { get; set; }  // e.g., "Renter is responsible"
    public required string PetPolicy { get; set; }  // e.g., "Pets Allowed"
    public string? PropertyFees { get; set; }  // e.g., "Must have 3x the rent in total household income"
    public required double Latitude { get; set; }
    public required double Longitude { get; set; }
    public required string Contact { get; set; }  // e.g., "Send a Message"
}

}