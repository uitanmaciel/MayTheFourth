using System.Text.Json.Serialization;

namespace MayTheFourth.Application.Vehicles.Responses;

public record VehicleResponse
{
    [JsonPropertyName("name")] public string Name { get; set; } = null!;
    [JsonPropertyName("model")] public string Model { get; set; } = null!;
    [JsonPropertyName("manufacturer")] public string Manufacturer { get; set; } = null!;
    [JsonPropertyName("costInCredits")] public string CostInCredits { get; set; } = null!;
    [JsonPropertyName("length")] public string Length { get; set; } = null!;
    [JsonPropertyName("maxSpeed")] public string MaxSpeed { get; set; } = null!;
    [JsonPropertyName("crew")] public string Crew { get; set; } = null!;
    [JsonPropertyName("passengers")] public string Passengers { get; set; } = null!;
    [JsonPropertyName("cargoCapacity")] public string CargoCapacity { get; set; } = null!;
    [JsonPropertyName("consumables")] public string Consumables { get; set; } = null!;
    [JsonPropertyName("class")] public string VehicleClass { get; set; } = null!;
    [JsonPropertyName("movies")] public List<VehicleMovieResponse> Movies { get; set; } = new();
}