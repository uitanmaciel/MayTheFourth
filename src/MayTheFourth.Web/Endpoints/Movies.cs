using MayTheFourth.Application.Movies.Interfaces.Services;

namespace MayTheFourth.Web.Endpoints;

public static class Movies
{
    public static void MoviesEndPoints(this WebApplication app)
    {
        app.MapGet("/api/v1/movies/get-by-name/{name}", async (IMovieService service, string name) =>
        {
            var result = await service.SearchByName(name);
            return result;
        });
    }
}