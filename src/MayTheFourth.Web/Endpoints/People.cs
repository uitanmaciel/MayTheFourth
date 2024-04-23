using MayTheFourth.Application.Peoples.Interfaces.Services;

namespace MayTheFourth.Web.Endpoints;

public static class People
{
    public static void PeopleEndPoints(this WebApplication app)
    {
        app.MapGet("/api/v1/people/get-all", async (IPeopleService service) =>
        {
            var result = await service.ListAll();
            return result;
        });

        app.MapGet("/api/v1/people/search-by-name/{string:name}", async (IPeopleService service, string name) =>
        {
            var result = await service.SearchByName(name);
            return result;            
        });

        app.MapGet("/api/v1/people/search-by-gender/{string:gender}", async (IPeopleService service, string gender) =>
        {
            var result = await service.SearchByGender(gender);
            return result;
        });

        app.MapGet("/api/v1/people/search-by-height/{string:height}", async (IPeopleService service, string height) =>
        {
            var result = await service.SearchByHeight(height);
            return result;
        });

        app.MapGet("/api/v1/people/{int:id}", async (IPeopleService service, int id) =>
        {
            var result = await service.SearchById(id);
            return result;
        });
    }
}
