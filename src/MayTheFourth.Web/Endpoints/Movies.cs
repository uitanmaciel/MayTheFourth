using MayTheFourth.Application.Movies.Interfaces.Services;

namespace MayTheFourth.Web.Endpoints;

public static class Movies
{
    public static void MoviesEndpoints(this WebApplication app)
    {
        app.MapGet("/api/v1/movies", async (IMovieService service, int? skip, int? take) => await service.GetAllAsync(skip, take))
            .WithName("GetAllMovies")
            .WithTags("Movies")
            .WithSummary("Returns all movies from Star Wars universe.")
            .WithOpenApi();
        
        app.MapGet("/api/v1/movies/get-by-name/{title}", async (IMovieService service, string title) => await service.SearchByTitleAsync(title))
            .WithName("GetMoviesByName")
            .WithTags("Movies")
            .WithSummary("Returns a movie list by title.")
            .WithOpenApi();
        
        app.MapGet("/api/v1/movies/get-by-director/{director}", async (IMovieService service, string director) => await service.SearchByDirectorAsync(director))
            .WithName("GetMoviesByDirector")
            .WithTags("Movies")
            .WithSummary("Returns a movie list by director.")
            .WithOpenApi();
        
        app.MapGet("/api/v1/movies/get-by-producer/{producer}", async (IMovieService service, string producer) => await service.SearchByProducerAsync(producer))
            .WithName("GetMoviesByProducer")
            .WithTags("Movies")
            .WithSummary("Returns a movie list by producer.")
            .WithOpenApi();
        
        app.MapGet("/api/v1/movies/get-by-release-date/{releaseDate}", async (IMovieService service, string releaseDate) => await service.SearchByReleaseDateAsync(releaseDate))
            .WithName("GetMoviesByReleaseDate")
            .WithTags("Movies")
            .WithSummary("Returns a movie list by release date.")
            .WithOpenApi();
    }
}