using MayTheFourth.Application.Vehicles.Interfaces.Services;

namespace MayTheFourth.Web.Endpoints;

public static class Vehicles
{
    public static void VehiclesEndpoints(this WebApplication app)
    {
        app.MapGet("/api/v1/vehicles/get-all", async (IVehicleServices services) =>
        {
            return await services.GetVehiclesAsync();
        }).WithName("GetAllVehicles")
        .WithTags("Vehicles");
        
        app.MapGet("/api/v1/vehicles/get-by-model/{model}", async (IVehicleServices services, string model) =>
        {
            return await services.GetVehicleByModelAsync(model);
        }).WithName("GetVehicleById")
        .WithTags("Vehicles");

        app.MapGet("/api/v1/vehicles/get-by-name/{name}", async (IVehicleServices services, string name) =>
        {
            return await services.GetVehicleByNameAsync(name);
        }).WithName("GetVehicleByName")
        .WithTags("Vehicles");

        app.MapGet("/api/v1/vehicles/get-by-class/{vehicleClass}", async (IVehicleServices services, string vehicleClass) =>
        {
            return await services.GetVehicleByClassAsync(vehicleClass);
        }).WithName("GetVehicleByClass")
        .WithTags("Vehicles");
    }
}