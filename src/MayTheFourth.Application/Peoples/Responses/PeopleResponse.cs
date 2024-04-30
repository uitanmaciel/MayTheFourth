using System.Text.Json.Serialization;

namespace MayTheFourth.Application.Peoples.Responses;

public record PeopleResponse
{
    [JsonPropertyName("name")]public string Name { get; set; } = null!;
    [JsonPropertyName("height")]public string Height { get; set; } = null!;
    [JsonPropertyName("weight")]public string Weight { get; set; } = null!;
    [JsonPropertyName("hairColor")]public string HairColor { get; set; } = null!;
    [JsonPropertyName("skinColor")]public string SkinColor { get; set; } = null!;
    [JsonPropertyName("eyeColor")]public string EyeColor { get; set; } = null!;
    [JsonPropertyName("brithYear")]public string BirthYear { get; set; } = null!;
    [JsonPropertyName("gender")]public string Gender { get; set; } = null!;
    [JsonPropertyName("planet")]public PeoplePlanetResponse Planet { get; set; } = null!;
    [JsonPropertyName("movies")]public IList<PeopleMoviesResponse> Movies { get; set; } = null!;
}