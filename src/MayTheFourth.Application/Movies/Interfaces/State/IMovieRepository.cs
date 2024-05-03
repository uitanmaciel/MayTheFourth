namespace MayTheFourth.Application.Movies.Interfaces.State;

public interface IMovieRepository
{
    Task<IList<Movie>> GetAllAsync(int? skip, int? take, CancellationToken cancellationToken = default);
    Task<IList<Movie>> SearchByTitleAsync(string title, CancellationToken cancellationToken = default);
    Task<IList<Movie>> SearchByDirectorAsync(string director, CancellationToken cancellationToken = default);
    Task<IList<Movie>> SearchByProducerAsync(string producer, CancellationToken cancellationToken = default);
    Task<IList<Movie>> SearchByReleaseDateAsync(string releaseDate, CancellationToken cancellationToken = default);
}