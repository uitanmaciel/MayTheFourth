using MayTheFourth.Application.Movies;
using MayTheFourth.Application.Starships.Responses;

namespace MayTheFourth.Application.Starships;

public sealed class Starship()
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
    public string HyperdriveRating { get; private set; } = null!;
    public string Mglt { get; private set; } = null!;
    public string Consumables { get; private set; } = null!;
    public string Class { get; private set; } = null!;
    public IList<Movie> Movies { get; private set; } = [];

    public Starship(
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
        string hyperdriveRating, 
        string mglt, 
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
        HyperdriveRating = hyperdriveRating;
        Mglt = mglt;
        Consumables = consumables;
        Class = @class;
    }
    
    public static StarshipResponse ToResponse(Starship? starship) => FromModelToResponse(starship);
    public static IList<StarshipResponse> ToResponse(IList<Starship> starships) => FromModelToResponse(starships);
    
    private static StarshipResponse FromModelToResponse(Starship? starship)
    {
        if (starship is null) return new StarshipResponse();
        
        return new StarshipResponse
        {
            Name = starship.Name,
            Model = starship.Model,
            Manufacturer = starship.Manufacturer,
            CostInCredits = starship.CostInCredits,
            Length = string.Concat(starship.Length, " meters"),
            MaxSpeed = string.Concat(starship.MaxSpeed, " km/h"),
            Crew = starship.Crew,
            Passengers = starship.Passengers,
            CargoCapacity = string.Concat(starship.CargoCapacity, " kg"),
            HyperdriveRating = starship.HyperdriveRating,
            Mglt = starship.Mglt,
            Consumables = starship.Consumables,
            StarshipClass = starship.Class,
            Movies = ToStarshipMovieResponse(starship)
        };
    }
    
    private static IList<StarshipResponse> FromModelToResponse(IList<Starship> starships)
        => starships.Select(FromModelToResponse).ToList();
    
    private static IList<StarshipMovieResponse> ToStarshipMovieResponse(Starship? starship)
    {
        if (starship is null) return new List<StarshipMovieResponse>();

        return starship.Movies
            .Select(movie => new StarshipMovieResponse
            {
                Id = movie.Id,
                Title = movie.Title,
            }).ToList();
    }
}