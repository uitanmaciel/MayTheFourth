using System.Text.Json.Serialization;

namespace MayTheFourth.Application.Peoples.Responses;

public record PeoplePlanetResponse
{
    [JsonPropertyName("id")]public int Id { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; } = null!;
}