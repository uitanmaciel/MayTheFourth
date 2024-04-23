using MayTheFourth.Application.Movies;
using MayTheFourth.Application.Movies.Interfaces.State;

namespace MayTheFourth.State.Movies;

public class MovieRepository : IMovieRepository
{
    public Task<List<MovieModel>> SearchAllMovies(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<List<MovieModel>> SearchByDirector(string director, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<MovieModel> SearchByReleaseDate(DateTime releaseDate, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<MovieModel> SearchByTitle(string title, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}