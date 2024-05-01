using MayTheFourth.Application.Planets.Interfaces.Services;

namespace MayTheFourth.Web.Endpoints;

public static class Planets
{
    public static void PlanetEndpoints(this WebApplication app)
    {
        app.MapGet("/api/v1/planets/get-all", async (IPlanetServices services) =>
        {
            var result = await services.GetPlanetsAsync();
            return result;
        }).WithName("GetAllPlanets")
        .WithTags("Planets");
        
        app.MapGet("/api/v1/planets/get-by-code/{code}", async (IPlanetServices services, int code) =>
        {
            var result = await services.GetPlanetByCodeAsync(code);
            return result;
        }).WithName("GetPlanetByCode")
        .WithTags("Planets");

        app.MapGet("/api/v1/planets/get-by-name", async (IPlanetServices services, string name) =>
        {
            var result = await services.GetPlanetByNameAsync(name);
            return result;
        }).WithName("GetPlanetByName")
        .WithTags("Planets");
    }
}