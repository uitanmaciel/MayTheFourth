namespace MayTheFourth.Application.Movies.Interfaces.State;

public interface IMovieRepository
{
    Task<MovieModel> SearchByTitle(string title, CancellationToken cancellationToken = default);
}