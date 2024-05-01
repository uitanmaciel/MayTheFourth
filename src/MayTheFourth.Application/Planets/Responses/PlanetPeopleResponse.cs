using System.Text.Json.Serialization;

namespace MayTheFourth.Application.Planets.Responses;

public record PlanetPeopleResponse
{
    [JsonPropertyName("id")] public int Id { get; init; }
    [JsonPropertyName("name")] public string Name { get; init; } = null!;
}