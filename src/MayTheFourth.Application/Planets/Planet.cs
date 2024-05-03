using MayTheFourth.Application.Movies;
using MayTheFourth.Application.Peoples;
using MayTheFourth.Application.Planets.Responses;

namespace MayTheFourth.Application.Planets;

public sealed class Planet()
{
    public int Id { get; private set; }
    public string Name { get; private set; } = null!;
    public string RotationPeriod { get; private set; } = null!;
    public string OrbitalPeriod { get; private set; } = null!;
    public string Diameter { get; private set; } = null!;
    public string Climate { get; private set; } = null!;
    public string Gravity { get; private set; } = null!;
    public string Terrain { get; private set; } = null!;
    public string SurfaceWater { get; private set; } = null!;
    public string Population { get; private set; } = null!;
    public IList<People> Peoples { get; private set; } = [];
    public IList<Movie> Movies { get; private set; } = [];
    
    public Planet( 
        int id, 
        string name, 
        string rotationPeriod, 
        string orbitalPeriod, 
        string diameter, 
        string climate, 
        string gravity, 
        string terrain, 
        string surfaceWater, 
        string population) : this()
    {
        Id = id;
        Name = name;
        RotationPeriod = rotationPeriod;
        OrbitalPeriod = orbitalPeriod;
        Diameter = diameter;
        Climate = climate;
        Gravity = gravity;
        Terrain = terrain;
        SurfaceWater = surfaceWater;
        Population = population;
    }
    
    public static PlanetResponse ToResponse(Planet? planet) => FromModelToResponse(planet);
    public static IList<PlanetResponse> ToResponse(IList<Planet> planets) => FromModelToResponse(planets);
    
    private static PlanetResponse FromModelToResponse(Planet? planet)
    {
        if (planet is null) return new PlanetResponse();
        
        return new PlanetResponse
        {
            Name = planet.Name,
            RotationPeriod = string.Concat(planet.RotationPeriod, " hours"),
            OrbitalPeriod = string.Concat(planet.OrbitalPeriod, " days"),
            Diameter = string.Concat(planet.Diameter, " km"),
            Climate = planet.Climate,
            Gravity = planet.Gravity,
            Terrain = planet.Terrain,
            SurfaceWater = string.Concat(planet.SurfaceWater, "%"),
            Population = planet.Population,
            Characters = ToPlanetPeopleResponse(planet),
            Movies = ToPlanetMovieResponse(planet),
        };
    }
    
    private static IList<PlanetResponse> FromModelToResponse(IList<Planet> planets)
    {
        return planets.Select(FromModelToResponse).ToList();
    }
    
    private static IList<PlanetPeopleResponse> ToPlanetPeopleResponse(Planet? planet)
    {
        if (planet is null) return new List<PlanetPeopleResponse>();

        return planet.Peoples
            .Select(people => new PlanetPeopleResponse
            {
                Id = people.Id,
                Name = people.Name
            }).ToList();
    }

    private static IList<PlanetMovieResponse> ToPlanetMovieResponse(Planet? planet)
    {
        if (planet is null) return new List<PlanetMovieResponse>();

        return planet.Movies
            .Select(movie => new PlanetMovieResponse
            {
                Id = movie.Id,
                Title = movie.Title
            }).ToList();
    }
}