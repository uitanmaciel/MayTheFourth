using System.Text.Json.Serialization;

namespace MayTheFourth.Application.Movies.Responses;

public record MovieResponse
{
    [JsonPropertyName("title")] public string Title { get; set; } = null!;
    [JsonPropertyName("episode")] public string Episode { get; set; } = null!;
    [JsonPropertyName("openingCrawl")] public string OpeningCrawl { get; set; } = null!;
    [JsonPropertyName("director")] public string Director { get; set; } = null!;
    [JsonPropertyName("producer")] public string Producer { get; set; } = null!;
    [JsonPropertyName("releaseDate")] public string ReleaseDate { get; set; } = null!;
    [JsonPropertyName("characters")] public IList<MoviePeopleResponse> Peoples { get; set; } = null!;
    [JsonPropertyName("planets")] public IList<MoviePlanetResponse> Planets { get; set; } = null!;
    [JsonPropertyName("vehicles")] public IList<MovieVehicleResponse> Vehicles { get; set; } = null!;
    [JsonPropertyName("starships")] public IList<MovieStarshipResponse> Starships { get; set; } = null!;
}