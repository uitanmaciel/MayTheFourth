using MayTheFourth.Application.Starships.Interfaces.Services;

namespace MayTheFourth.Web.Endpoints;

public static class Starships
{
    public static void StarshipEndpoints(this WebApplication app)
    {
        app.MapGet("/api/v1/starships", async (IStarshipServices services) => await services.GetStarshipsAsync())
            .WithName("GetStarships")
            .WithTags("Starships");
        
        app.MapGet("/api/v1/starships/get-by-name/{name}", async (IStarshipServices services, string name) => await services.GetStarshipByNameAsync(name))
            .WithName("GetStarshipByName")
            .WithTags("Starships");
        
        app.MapGet("/api/v1/starships/get-by-model/{model}", async (IStarshipServices services, string model) => await services.GetStarshipByModelAsync(model))
            .WithName("GetStarshipByModel")
            .WithTags("Starships");
        
        app.MapGet("/api/v1/starships/get-by-class/{class}", async (IStarshipServices services, string @class) => await services.GetStarshipByClassAsync(@class))
            .WithName("GetStarshipByClass")
            .WithTags("Starships");
    }
}