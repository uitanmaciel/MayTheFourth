using MayTheFourth.Application.Movies.Interfaces.Services;
using MayTheFourth.Application.Movies.Queries;

namespace MayTheFourth.Application.Movies.Services;

public sealed class MovieService(IMediator mediator) : IMovieService
{
    public async Task<Result<MovieModel>> SearchByName(string name, CancellationToken cancellationToken = default)
    {
        var movie = await mediator.Send(new SearchByNameQuery(name), cancellationToken);
        if (movie is null)
            return Result<MovieModel>.Failure(Error.NotFound);

        return Result<MovieModel>.Ok(movie);
    }
}