using MayTheFourth.Application.Peoples.Interfaces.Services;
using MayTheFourth.Application.Peoples.Responses;

namespace MayTheFourth.Web.Endpoints;

public static class Characters
{
    public static void PeopleEndpoints(this WebApplication app)
    {
        app.MapGet("/api/v1/peoples", async (IPeopleServices services, int? skip, int? take) => await services.GetPeoplesAsync(skip, take))
            .WithName("GetAllPeoples")
            .WithTags("Characters")
            .WithSummary("Returns all characters from Star Wars universe.")
            .WithOpenApi();
        
        app.MapGet("/api/v1/peoples/get-by-id/{id}", async (IPeopleServices services, int id) => await services.GetPeopleByIdAsync(id))
            .WithName("GetPeopleByCode")
            .WithTags("Characters")
            .WithSummary("Returns a character by Id.")
            .WithOpenApi();
        
        app.MapGet("/api/v1/peoples/get-by-name/{name}", async (IPeopleServices services, string name) => await services.GetPeopleByNameAsync(name))
            .WithName("GetPeopleByName")
            .WithTags("Characters")
            .WithSummary("Returns a character list by name.")
            .WithOpenApi();

        app.MapGet("/api/v1/get-by-gender/{gender}", async (IPeopleServices services, string gender) => await services.GetPeopleByGenderAsync(gender))
            .WithName("GetPeopleByGender")
            .WithTags("Characters")
            .WithSummary("Returns a character list by gender.")
            .WithOpenApi();
    }
}