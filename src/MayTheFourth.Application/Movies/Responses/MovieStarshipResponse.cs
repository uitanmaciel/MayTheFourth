using System.Text.Json.Serialization;

namespace MayTheFourth.Application.Movies.Responses;

public record MovieStarshipResponse
{
    [JsonPropertyName("id")] public int Code { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; } = null!;
}