using System.Text.Json.Serialization;

namespace MayTheFourth.Application.Planets.Responses;

public record PlanetMovieResponse
{
    [JsonPropertyName("id")] public int Id { get; init; }
    [JsonPropertyName("title")] public string Title { get; init; } = null!;
}