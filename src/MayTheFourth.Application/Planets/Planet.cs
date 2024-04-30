using MayTheFourth.Application.Movies;
using MayTheFourth.Application.Peoples;

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
}