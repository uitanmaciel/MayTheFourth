using MayTheFourth.Application.Movies;
using MayTheFourth.Application.Peoples.Responses;
using MayTheFourth.Application.Planets;

namespace MayTheFourth.Application.Peoples;

public sealed class People()
{
    public int Id { get; set; }
    public int Code { get; set; }
    public string Name { get; set; } = null!;
    public string Height { get; set; } = null!;
    public string Weight { get; set; } = null!;
    public string HairColor { get; set; } = null!;
    public string SkinColor { get; set; } = null!;
    public string EyeColor { get; set; } = null!;
    public string BirthYear { get; set; } = null!;
    public string Gender { get; set; } = null!;
    public int MovieCode { get; set; }
    public int PlanetCode { get; set; }
    public IList<Planet> Planets { get; set; } = [];
    public IList<Movie> Movies { get; set; } = [];
    
    public People(
        int code, 
        string name, 
        string height, 
        string weight, 
        string hairColor, 
        string skinColor, 
        string eyeColor, 
        string birthYear, 
        string gender,
        int movieCode,
        int planetCode,
        IList<Planet> planets,
        IList<Movie> movies) : this()
    {
        Code = code;
        Name = name;
        Height = height;
        Weight = weight;
        HairColor = hairColor;
        SkinColor = skinColor;
        EyeColor = eyeColor;
        BirthYear = birthYear;
        Gender = gender;
        MovieCode = movieCode;
        PlanetCode = planetCode;
        Planets = planets;
        Movies = movies;
    }
    
    public static PeopleResponse ToResponse(People? people) => FromModelToResponse(people);
    public static IList<PeopleResponse> ToResponse(IList<People> peoples) => FromModelToResponse(peoples);
    
    private static PeopleResponse FromModelToResponse(People? people)
    {
        if (people is null) return new PeopleResponse();

        return new PeopleResponse
        {
            Name = people.Name,
            Height = people.Height,
            Weight = people.Weight,
            HairColor = people.HairColor,
            SkinColor = people.SkinColor,
            EyeColor = people.EyeColor,
            BirthYear = people.BirthYear,
            Gender = people.Gender,
            Planet = ToPeoplePlanetReponse(people),
            Movies = toPeopleMoviesResponses(people)
        };
    }
    
    private static IList<PeopleResponse> FromModelToResponse(IList<People> peoples)
    {
        return peoples.Select(FromModelToResponse).ToList();
    }
    
    private static PeoplePlanetResponse ToPeoplePlanetReponse(People? people)
    {
        if (people is null) return new PeoplePlanetResponse();

        return people.Planets
            .Select(people => new PeoplePlanetResponse
            {
                Id = people.Code,
                Name = people.Name
            }).FirstOrDefault();
    }
    
    private static IList<PeopleMoviesResponse> toPeopleMoviesResponses(People? people)
    {
        if (people is null) return new List<PeopleMoviesResponse>();

        return people.Movies
            .GroupBy(m => m.Code)
            .Select(movie => movie.First())
            .Select(movie => new PeopleMoviesResponse
            {
                Id = movie.Code,
                Title = movie.Title,
            }).ToList();
    }
}