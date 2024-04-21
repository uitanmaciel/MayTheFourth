using MayTheFourth.Application.Movies;
using MayTheFourth.Application.Movies.Interfaces.State;

namespace MayTheFourth.State.Movies;

public class MovieRepository : IMovieRepository
{
    public Task<MovieModel> SearchByName(string name, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}