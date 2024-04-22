namespace MayTheFourth.Application.Movies.Interfaces.State;

public interface IMovieRepository
{
    Task<MovieModel> SearchByTitle(string title, CancellationToken cancellationToken = default);
    Task<MovieModel> SearchByDirector(string director, CancellationToken cancellationToken = default);
    Task<MovieModel> SearchByProducer(string producer, CancellationToken cancellationToken = default);
    Task<MovieModel> SearchByReleaseDate(DateTime releaseDate, CancellationToken cancellationToken = default);
    Task<MovieModel> SearchAllMovies(CancellationToken cancellationToken = default);

}