namespace MayTheFourth.Application.Movies.Interfaces.State;

public interface IMovieRepository
{
    Task<IList<Movie>> SearchByTitleAsync(string title, CancellationToken cancellationToken = default);
    Task<IList<Movie>> SearchByDirectorAsync(string director, CancellationToken cancellationToken = default);
    Task<IList<Movie>> SearchByProducerAsync(string producer, CancellationToken cancellationToken = default);
    Task<IList<Movie>> SearchByReleaseDateAsync(string releaseDate, CancellationToken cancellationToken = default);
    Task<IList<Movie>> GetAllAsync(CancellationToken cancellationToken = default);
}