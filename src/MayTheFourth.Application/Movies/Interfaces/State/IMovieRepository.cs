namespace MayTheFourth.Application.Movies.Interfaces.State;

public interface IMovieRepository
{
    Task<MovieModel> SearchByName(string name, CancellationToken cancellationToken = default);
}