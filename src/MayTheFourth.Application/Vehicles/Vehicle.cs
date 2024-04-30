using MayTheFourth.Application.Movies;

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
}