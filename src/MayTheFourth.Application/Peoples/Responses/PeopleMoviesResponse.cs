using System.Text.Json.Serialization;

namespace MayTheFourth.Application.Peoples.Responses;

public record PeopleMoviesResponse
{
    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("title")] public string Title { get; set; } = null!;
}