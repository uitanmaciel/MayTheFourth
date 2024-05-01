using System.Text.Json.Serialization;

namespace MayTheFourth.Application.Planets.Responses;

public record PlanetResponse
{
    [JsonPropertyName("name")] public string Name { get; init; } = null!;
    [JsonPropertyName("rotationPeriod")] public string RotationPeriod { get; init; } = null!;
    [JsonPropertyName("orbitalPeriod")] public string OrbitalPeriod { get; init; } = null!;
    [JsonPropertyName("diameter")] public string Diameter { get; init; } = null!;
    [JsonPropertyName("climate")] public string Climate { get; init; } = null!;
    [JsonPropertyName("gravity")] public string Gravity { get; init; } = null!;
    [JsonPropertyName("terrain")] public string Terrain { get; init; } = null!;
    [JsonPropertyName("surfaceWater")] public string SurfaceWater { get; init; } = null!;
    [JsonPropertyName("population")] public string Population { get; init; } = null!;
    [JsonPropertyName("characters")] public IList<PlanetPeopleResponse> Characters { get; init; } = [];
    [JsonPropertyName("movies")] public IList<PlanetMovieResponse> Movies { get; init; } = [];
}