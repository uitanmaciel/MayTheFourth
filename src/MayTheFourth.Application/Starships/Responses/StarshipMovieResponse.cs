using System.Text.Json.Serialization;

namespace MayTheFourth.Application.Starships.Responses;

public record StarshipMovieResponse
{
    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("title")] public string Title { get; set; } = null!;
}