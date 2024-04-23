using MayTheFourth.Application.Movies.Interfaces.Services;

namespace MayTheFourth.Web.Endpoints;

public static class Movies
{
    public static void MoviesEndPoints(this WebApplication app)
    {
        app.MapGet("/api/v1/movies/get-all-movies", async (IMovieService service) =>
        {
            var result = await service.SearchAllMovies();
            return result;
        });

        app.MapGet("/api/v1/movies/get-by-title/{title}", async (IMovieService service, string title) =>
        {
            var result = await service.SearchByTitle(title);
            return result;
        });

        app.MapGet("/api/v1/movies/get-by-director/{director}", async (IMovieService service, string director) =>
        {
            var result = await service.SearchByDirector(director);
            return result;
        });

        app.MapGet("/api/v1/movies/get-by-releaseDate/{releaseDate}", async (IMovieService service, DateTime releaseDate) =>
        {
            var result = await service.SearchByReleaseDate(releaseDate);
            return result;
        });
    }
}