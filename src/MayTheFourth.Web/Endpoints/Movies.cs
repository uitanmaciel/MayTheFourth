using MayTheFourth.Application.Movies.Interfaces.Services;

namespace MayTheFourth.Web.Endpoints;

public static class Movies
{
    public static void MoviesEndpoints(this WebApplication app)
    {
        app.MapGet("/api/v1/movies", async (IMovieService service) => await service.GetAllAsync())
            .WithName("GetAllMovies")
            .WithTags("Movies");
        
        app.MapGet("/api/v1/movies/get-by-name/{title}", async (IMovieService service, string title) => await service.SearchByTitleAsync(title))
            .WithName("GetMoviesByName")
            .WithTags("Movies");
        
        app.MapGet("/api/v1/movies/get-by-director/{director}", async (IMovieService service, string director) => await service.SearchByDirectorAsync(director))
            .WithName("GetMoviesByDirector")
            .WithTags("Movies");
        
        app.MapGet("/api/v1/movies/get-by-producer/{producer}", async (IMovieService service, string producer) => await service.SearchByProducerAsync(producer))
            .WithName("GetMoviesByProducer")
            .WithTags("Movies");
        
        app.MapGet("/api/v1/movies/get-by-release-date/{releaseDate}", async (IMovieService service, string releaseDate) => await service.SearchByReleaseDateAsync(releaseDate))
            .WithName("GetMoviesByReleaseDate")
            .WithTags("Movies");
    }
}