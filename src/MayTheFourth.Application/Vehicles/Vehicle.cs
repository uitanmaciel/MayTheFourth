using MayTheFourth.Application.Movies;
using MayTheFourth.Application.Vehicles.Responses;

namespace MayTheFourth.Application.Vehicles;

public sealed class Vehicle()
{
    public int Id { get; private set; }
    public string Name { get; private set; } = null!;
    public string Model { get; private set; } = null!;
    public string Manufacturer { get; private set; } = null!;
    public string CostInCredits { get; private set; } = null!;
    public string Length { get; private set; } = null!;
    public string MaxSpeed { get; private set; } = null!;
    public string Crew { get; private set; } = null!;
    public string Passengers { get; private set; } = null!;
    public string CargoCapacity { get; private set; } = null!;
    public string Consumables { get; private set; } = null!;
    public string Class { get; private set; } = null!;
    public IList<Movie> Movies { get; private set; } = [];
    
    public Vehicle(
        int id, 
        string name, 
        string model, 
        string manufacturer, 
        string costInCredits, 
        string length, 
        string maxSpeed, 
        string crew, 
        string passengers, 
        string cargoCapacity, 
        string consumables, 
        string @class) : this()
    {
        Id = id;
        Name = name;
        Model = model;
        Manufacturer = manufacturer;
        CostInCredits = costInCredits;
        Length = length;
        MaxSpeed = maxSpeed;
        Crew = crew;
        Passengers = passengers;
        CargoCapacity = cargoCapacity;
        Consumables = consumables;
        Class = @class;
    }
    
    public static VehicleResponse ToResponse(Vehicle? vehicle) => FromModelToResponse(vehicle);
    public static IList<VehicleResponse> ToResponse(IList<Vehicle> vehicles) => FromModelToResponse(vehicles);
    
    private static VehicleResponse FromModelToResponse(Vehicle? vehicle)
    {
        if (vehicle is null) return new VehicleResponse();
        
        return new VehicleResponse
        {
            Name = vehicle.Name,
            Model = vehicle.Model,
            Manufacturer = vehicle.Manufacturer,
            CostInCredits = vehicle.CostInCredits,
            Length = string.Concat(vehicle.Length, " meters"),
            MaxSpeed = string.Concat(vehicle.MaxSpeed, " km/h"),
            Crew = vehicle.Crew,
            Passengers = vehicle.Passengers,
            CargoCapacity = string.Concat(vehicle.CargoCapacity, " kg"),
            Consumables = vehicle.Consumables,
            VehicleClass = vehicle.Class,
            Movies = ToVehicleMovieResponse(vehicle)
        };
    }
    
    private static IList<VehicleResponse> FromModelToResponse(IList<Vehicle> vehicles)
        => vehicles.Select(FromModelToResponse).ToList();
    
    private static List<VehicleMovieResponse> ToVehicleMovieResponse(Vehicle? vehicle)
    {
        if(vehicle is null) return new List<VehicleMovieResponse>();

        return vehicle.Movies
            .Select(movie => new VehicleMovieResponse
            {
                Id = movie.Id,
                Title = movie.Title,
            }).ToList();
    }
}