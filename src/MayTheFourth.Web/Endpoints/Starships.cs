using MayTheFourth.Application.Starships.Interfaces.Services;

namespace MayTheFourth.Web.Endpoints;

public static class Starships
{
    public static void StarshipEndpoints(this WebApplication app)
    {
        app.MapGet("/api/v1/starships", async (IStarshipServices services, int? skip, int? take) => await services.GetStarshipsAsync(skip, take))
            .WithName("GetStarships")
            .WithTags("Starships")
            .WithSummary("Returns all starships from Star Wars universe.")
            .WithOpenApi();
        
        app.MapGet("/api/v1/starships/get-by-name/{name}", async (IStarshipServices services, string name) => await services.GetStarshipByNameAsync(name))
            .WithName("GetStarshipByName")
            .WithTags("Starships")
            .WithSummary("Returns a starship list by name.")
            .WithOpenApi();
        
        app.MapGet("/api/v1/starships/get-by-model/{model}", async (IStarshipServices services, string model) => await services.GetStarshipByModelAsync(model))
            .WithName("GetStarshipByModel")
            .WithTags("Starships")
            .WithSummary("Returns a starship list by model.")
            .WithOpenApi();
        
        app.MapGet("/api/v1/starships/get-by-class/{class}", async (IStarshipServices services, string @class) => await services.GetStarshipByClassAsync(@class))
            .WithName("GetStarshipByClass")
            .WithTags("Starships")
            .WithSummary("Returns a starship list by class.")
            .WithOpenApi();
    }
}