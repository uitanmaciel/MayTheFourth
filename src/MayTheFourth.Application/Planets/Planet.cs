using MayTheFourth.Application.Movies;
using MayTheFourth.Application.Peoples;
using MayTheFourth.Application.Planets.Responses;

namespace MayTheFourth.Application.Planets;

public sealed class Planet()
{
    public int Id { get; set; }
    public int Code { get; set; }
    public string Name { get; set; } = null!;
    public string RotationPeriod { get; set; } = null!;
    public string OrbitalPeriod { get; set; } = null!;
    public string Diameter { get; set; } = null!;
    public string Climate { get; set; } = null!;
    public string Gravity { get; set; } = null!;
    public string Terrain { get; set; } = null!;
    public string SurfaceWater { get; set; } = null!;
    public string Population { get; set; } = null!;
    public int CharacterCode { get; set; }
    public int MovieCode { get; set; }
    public IList<People> Peoples { get; set; } = [];
    public IList<Movie> Movies { get; set; } = [];
    
    public Planet(
        int code, 
        string name, 
        string rotationPeriod, 
        string orbitalPeriod, 
        string diameter, 
        string climate, 
        string gravity, 
        string terrain, 
        string surfaceWater, 
        string population,
        int characterCode,
        int movieCode,
        IList<People> peoples,
        IList<Movie> movies) : this()
    {
        Code = code;
        Name = name;
        RotationPeriod = rotationPeriod;
        OrbitalPeriod = orbitalPeriod;
        Diameter = diameter;
        Climate = climate;
        Gravity = gravity;
        Terrain = terrain;
        SurfaceWater = surfaceWater;
        Population = population;
        CharacterCode = characterCode;
        MovieCode = movieCode;
        Peoples = peoples;
        Movies = movies;
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
            .GroupBy(p => p.Code)
            .Select(people => people.First())
            .Select(people => new PlanetPeopleResponse
            {
                Id = people.Code,
                Name = people.Name
            }).ToList();
    }

    private static IList<PlanetMovieResponse> ToPlanetMovieResponse(Planet? planet)
    {
        if (planet is null) return new List<PlanetMovieResponse>();

        return planet.Movies
            .GroupBy(p => p.Code)
            .Select(movive => movive.First())
            .Select(movie => new PlanetMovieResponse
            {
                Id = movie.Code,
                Title = movie.Title
            }).ToList();
    }
}