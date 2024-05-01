using MayTheFourth.Application.Movies.Interfaces.Services;

namespace MayTheFourth.Web.Endpoints;

public static class Movies
{
    public static void MoviesEndpoints(this WebApplication app)
    {
        app.MapGet("/api/v1/movies/get-by-name/{title}", async (IMovieService service, string title) =>
        {
            var result = await service.SearchByTitleAsync(title);
            return result;
        }).WithTags("Movies");
        
        app.MapGet("/api/v1/movies/get-by-director/{director}", async (IMovieService service, string director) =>
        {
            var result = await service.SearchByDirectorAsync(director);
            return result;
        }).WithTags("Movies");
        
        app.MapGet("/api/v1/movies/get-by-producer/{producer}", async (IMovieService service, string producer) =>
        {
            var result = await service.SearchByProducerAsync(producer);
            return result;
        }).WithTags("Movies");
        
        app.MapGet("/api/v1/movies/get-by-release-date/{releaseDate}", async (IMovieService service, string releaseDate) =>
        {
            var result = await service.SearchByReleaseDateAsync(releaseDate);
            return result;
        }).WithTags("Movies");
        
        app.MapGet("/api/v1/movies/get", async (IMovieService service) =>
        {
            var result = await service.GetAllAsync();
            return result;
        }).WithTags("Movies");
    }
}