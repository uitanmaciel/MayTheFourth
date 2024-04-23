namespace MayTheFourth.Application.Movies.Interfaces.Services;

public interface IMovieService
{
    Task<Result<MovieModel>> SearchByTitle(string title, CancellationToken cancellationToken = default);
}