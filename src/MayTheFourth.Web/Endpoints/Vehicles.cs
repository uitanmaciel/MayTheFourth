using MayTheFourth.Application.Vehicles.Interfaces.Services;

namespace MayTheFourth.Web.Endpoints;

public static class Vehicles
{
    public static void VehiclesEndPoints(this WebApplication app)
    {
        app.MapGet("/api/v1/vehicles/get-all", async (IVehicleService service) =>
        {
            var result = await service.ListAll();
            return result;
        });

        app.MapGet("/api/v1/vehicles/search-by-name/{string:name}", async (IVehicleService service, string name) =>
        {
            var result = await service.SearchByName(name);
            return result;
        });

        app.MapGet("/api/v1/vehicles/search-by-class/{string:class}", async (IVehicleService service, string @class) =>
        {
            var result = await service.SearchByClass(@class);
            return result;
        });

        app.MapGet("/api/v1/vehicles/search-by-model/{string:model}", async (IVehicleService service, string model) =>
        {
            var result = await service.SearchByModel(model);
            return result;
        });

        app.MapGet("/api/v1/vehicles/{int:id}", async (IVehicleService service, int id) =>
        {
            var result = await service.SearchById(id);
            return result;
        });
    }
}
