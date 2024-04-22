using MayTheFourth.Application.Movies.Interfaces.Services;
using MayTheFourth.Application.Movies.Queries;
using System.IO;

namespace MayTheFourth.Application.Movies.Services;

public sealed class MovieService(IMediator mediator) : IMovieService
{
    public async Task<Result<MovieModel>> SearchAllMovies(CancellationToken cancellationToken = default)
    {
        var movie = await mediator.Send(new SearchAllMoviesQuery(), cancellationToken);
        if (movie is null)
            return Result<MovieModel>.Failure(Error.NotFound);

        return Result<MovieModel>.Ok(movie);
    }
    public async Task<Result<MovieModel>> SearchByTitle(string title, CancellationToken cancellationToken = default)
    {
        var movie = await mediator.Send(new SearchByTitleQuery(title), cancellationToken);
        if (movie is null)
            return Result<MovieModel>.Failure(Error.NotFound);

        return Result<MovieModel>.Ok(movie);
    }

    public async Task<Result<MovieModel>> SearchByDirector(string director, CancellationToken cancellationToken = default)
    {
        var movie = await mediator.Send(new SearchByDirectorQuery(director), cancellationToken);
        if (movie is null)
            return Result<MovieModel>.Failure(Error.NotFound);

        return Result<MovieModel>.Ok(movie);
    }

    public async Task<Result<MovieModel>> SearchByProducer(string producer, CancellationToken cancellationToken = default)
    {
        var movie = await mediator.Send(new SearchByProducerQuery(producer), cancellationToken);
        if (movie is null)
            return Result<MovieModel>.Failure(Error.NotFound);

        return Result<MovieModel>.Ok(movie);
    }

    public async Task<Result<MovieModel>> SearchByReleaseDate(DateTime releaseDate, CancellationToken cancellationToken = default)
    {
        var movie = await mediator.Send(new SearchByReleaseDateQuery(releaseDate), cancellationToken);
        if (movie is null)
            return Result<MovieModel>.Failure(Error.NotFound);

        return Result<MovieModel>.Ok(movie);
    }
}