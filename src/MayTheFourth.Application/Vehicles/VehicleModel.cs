using MayTheFourth.Application.Movies;

namespace MayTheFourth.Application.Vehicles;

public sealed class VehicleModel
{
    public int Id { get; set; } 
    public string Name { get; set; } = null!;
    public string Model { get; set; } = null!;
    public string Manufacturer { get; set; } = null!;
    public string CostInCredits { get; set; } = null!;
    public string Length { get; set; } = null!;
    public string MaxSpeed { get; set; } = null!;
    public string Crew { get; set; } = null!;
    public string Passengers { get; set; } = null!;
    public string CargoCapability { get; set; } = null!;
    public string Consumables { get; set; } = null!;
    public string Class { get; set; } = null!;      
    public IList<MovieModel> Movies { get; set; } = null!;

    public VehicleModel(
        int id, 
        string name, 
        string model, 
        string manufacturer, 
        string costInCredits, 
        string length, 
        string maxSpeed, 
        string crew, 
        string passengers, 
        string cargoCapability, 
        string consumables, 
        string @class, 
        IList<MovieModel> movies) : this()
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
        CargoCapability = cargoCapability;
        Consumables = consumables;
        Class = @class;
        Movies = movies;
    }

    public VehicleModel()
    {
    }
}