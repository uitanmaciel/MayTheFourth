using MayTheFourth.Application.Movies;
using MayTheFourth.Application.Vehicles.Responses;

namespace MayTheFourth.Application.Vehicles;

public sealed class Vehicle()
{
    public int Id { get; set; }
    public int Code { get; set; }
    public string Name { get; set; } = null!;
    public string Model { get; set; } = null!;
    public string Manufacturer { get; set; } = null!;
    public string CostInCredits { get; set; } = null!;
    public string Length { get; set; } = null!;
    public string MaxSpeed { get; set; } = null!;
    public string Crew { get; set; } = null!;
    public string Passengers { get; set; } = null!;
    public string CargoCapacity { get; set; } = null!;
    public string Consumables { get; set; } = null!;
    public string Class { get; set; } = null!;
    public int MovieCode { get; set; }
    public IList<Movie> Movies { get; set; } = [];
    
    public Vehicle(
        int code, 
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
        string @class,
        int movieCode,
        IList<Movie> movies) : this()
    {
        Code = code;
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
        MovieCode = movieCode;
        Movies = movies;
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
    {
        return vehicles.Select(FromModelToResponse).ToList();
    }
    
    private static List<VehicleMovieResponse> ToVehicleMovieResponse(Vehicle? vehicle)
    {
        if(vehicle is null) return new List<VehicleMovieResponse>();

        return vehicle.Movies
            .GroupBy(m => m.Code)
            .Select(movie => movie.First())
            .Select(movie => new VehicleMovieResponse
            {
                Id = movie.Code,
                Title = movie.Title,
            }).ToList();
    }
}