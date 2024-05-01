using MayTheFourth.Application.Vehicles.Interfaces.Services;

namespace MayTheFourth.Web.Endpoints;

public static class Vehicles
{
    public static void VehiclesEndpoints(this WebApplication app)
    {
        app.MapGet("/api/v1/vehicles", async (IVehicleServices services) => await services.GetVehiclesAsync())
            .WithName("GetVehicles")
            .WithTags("Vehicles");
        
        app.MapGet("/api/v1/vehicles/get-by-model/{model}", async (IVehicleServices services, string model) => await services.GetVehicleByModelAsync(model))
            .WithName("GetVehicleByModel")
            .WithTags("Vehicles");

        app.MapGet("/api/v1/vehicles/get-by-name/{name}", async (IVehicleServices services, string name) => await services.GetVehicleByNameAsync(name))
            .WithName("GetVehicleByName")
            .WithTags("Vehicles");

        app.MapGet("/api/v1/vehicles/get-by-class/{vehicleClass}", async (IVehicleServices services, string vehicleClass) => await services.GetVehicleByClassAsync(vehicleClass))
            .WithName("GetVehicleByClass")
            .WithTags("Vehicles");
    }
}