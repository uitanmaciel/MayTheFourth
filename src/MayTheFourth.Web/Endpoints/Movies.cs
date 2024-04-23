using MayTheFourth.Application.Movies.Interfaces.Services;

namespace MayTheFourth.Web.Endpoints;

public static class Movies
{
    public static void MoviesEndPoints(this WebApplication app)
    {
        app.MapGet("/api/v1/movies/get-by-name/{title}", async (IMovieService service, string title) =>
        {
            var result = await service.SearchByTitle(title);
            return result;
        });
    }
}