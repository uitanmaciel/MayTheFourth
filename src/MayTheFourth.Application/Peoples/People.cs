using MayTheFourth.Application.Movies;
using MayTheFourth.Application.Peoples.Responses;

namespace MayTheFourth.Application.Peoples;

public sealed class People()
{
    public int Id { get; private set; }
    public string Name { get; private set; } = null!;
    public string Height { get; private set; } = null!;
    public string Weight { get; private set; } = null!;
    public string HairColor { get; private set; } = null!;
    public string SkinColor { get; private set; } = null!;
    public string EyeColor { get; private set; } = null!;
    public string BirthYear { get; private set; } = null!;
    public string Gender { get; private set; } = null!;
    public int PlanetId { get; private set; }
    public IList<Movie> Movies { get; private set; } = [];
    
    public People(int id, string name, string height, string weight, string hairColor, string skinColor, string eyeColor, string birthYear, string gender, int planetId, IList<Movie> movies) : this()
    {
        Id = id;
        Name = name;
        Height = height;
        Weight = weight;
        HairColor = hairColor;
        SkinColor = skinColor;
        EyeColor = eyeColor;
        BirthYear = birthYear;
        Gender = gender;
        PlanetId = planetId;
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
            Height = string.Concat(people.Height, " cm"),
            Weight = string.Concat(people.Weight, " kg"),
            HairColor = people.HairColor,
            SkinColor = people.SkinColor,
            EyeColor = people.EyeColor,
            BirthYear = people.BirthYear,
            Gender = people.Gender,
            Planet = ToPeoplePlanetReponse(people),
            Movies = ToPeopleMoviesResponses(people)
        };
    }
    
    private static IList<PeopleResponse> FromModelToResponse(IList<People> peoples)
    {
        return peoples.Select(FromModelToResponse).ToList();
    }
    
    private static PeoplePlanetResponse ToPeoplePlanetReponse(People? people)
    {
        if (people is null) return new PeoplePlanetResponse();

        return new PeoplePlanetResponse
        {
            Id = people.PlanetId,
            Name = people.Name
        };
    }
    
    private static IList<PeopleMoviesResponse> ToPeopleMoviesResponses(People? people)
    {
        if (people is null) return new List<PeopleMoviesResponse>();

        return people.Movies
            .Select(movie => new PeopleMoviesResponse
            {
                Id = movie.Id,
                Title = movie.Title,
            }).ToList();
    }
}