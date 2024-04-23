using MayTheFourth.Application.Movies;
using MayTheFourth.Application.Movies.Interfaces.State;

namespace MayTheFourth.State.Movies;

public class MovieRepository : IMovieRepository
{
    public Task<MovieModel> SearchByTitle(string title, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}