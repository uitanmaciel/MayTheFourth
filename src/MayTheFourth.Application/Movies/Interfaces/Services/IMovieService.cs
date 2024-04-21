namespace MayTheFourth.Application.Movies.Interfaces.Services;

public interface IMovieService
{
    Task<Result<MovieModel>> SearchByName(string name, CancellationToken cancellationToken = default);
}