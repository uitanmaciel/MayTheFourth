namespace MayTheFourth.Application.Movies.Interfaces.State;

public interface IMovieRepository
{
    Task<MovieModel> SearchByTitle(string title, CancellationToken cancellationToken = default);
    Task<List<MovieModel>> SearchByDirector(string director, CancellationToken cancellationToken = default);
    Task<MovieModel> SearchByReleaseDate(DateTime releaseDate, CancellationToken cancellationToken = default);
    Task<List<MovieModel>> SearchAllMovies(CancellationToken cancellationToken = default);
}