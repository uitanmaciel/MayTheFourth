using MayTheFourth.Application.Movies;
using MayTheFourth.Application.Planets;

namespace MayTheFourth.Application.Peoples;

public sealed class PeopleModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Height { get; set; } = null!;
    public string Weight { get; set; } = null!;
    public string HairColor { get; set; } = null!;
    public string SkinColor { get; set; } = null!;
    public string EyeColor { get; set; } = null!;
    public string BirthYear { get; set;} = null!;
    public string Gender { get; set; } = null!;
    public PlanetModel Planet { get; set; } = null!;
    public IList<MovieModel> Movies { get; set; } = null!;

    public PeopleModel(
        int id,
        string name,
        string height,
        string weight,
        string hairColor,
        string skinColor,
        string eyeColor,
        string birthYear,
        string gender,
        PlanetModel planet,
        IList<MovieModel> movies) : this()
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
        Planet = planet;
        Movies = movies;
    }

    public PeopleModel()
    {
    }
}