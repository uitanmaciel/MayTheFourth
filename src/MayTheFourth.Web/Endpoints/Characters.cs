using MayTheFourth.Application.Peoples.Interfaces.Services;

namespace MayTheFourth.Web.Endpoints;

public static class Characters
{
    public static void PeopleEndpoints(this WebApplication app)
    {
        app.MapGet("/api/v1/peoples/get-all", async (IPeopleServices services) =>
        {
            var result = await services.GetPeoplesAsync();
            return result;
        }).WithName("GetAllPeoples")
        .WithTags("Characters");
        
        app.MapGet("/api/v1/peoples/get-by-code/{code}", async (IPeopleServices services, int code) =>
        {
            var result = await services.GetPeopleByCodeAsync(code);
            return result;
        }).WithName("GetPeopleByCode")
        .WithTags("Characters");
        
        app.MapGet("/api/v1/peoples/get-by-name/{name}", async (IPeopleServices services, string name) =>
        {
            var result = await services.GetPeopleByNameAsync(name);
            return result;
        }).WithName("GetPeopleByName")
        .WithTags("Characters");

        app.MapGet("/api/v1/get-by-gender/{gender}", async (IPeopleServices services, string gender) =>
        {
            var result = await services.GetPeopleByGenderAsync(gender);
            return result;
        }).WithName("GetPeopleByGender")
        .WithTags("Characters");
    }
}