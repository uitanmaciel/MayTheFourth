using System.Text.Json.Serialization;

namespace MayTheFourth.Application.Vehicles.Responses;

public record VehicleMovieResponse
{
    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("title")] public string Title { get; set; } = null!;
}