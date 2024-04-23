using MayTheFourth.Application.Movies.Interfaces.Services;
using MayTheFourth.Application.Movies.Queries;
using MayTheFourth.Application.Peoples;
using System.IO;

namespace MayTheFourth.Application.Movies.Services;

public sealed class MovieService(IMediator mediator) : IMovieService
{
    public async Task<Result<List<MovieModel>>> SearchAllMovies(CancellationToken cancellationToken = default)
    {
        var movieList = await mediator.Send(new SearchAllMoviesQuery(), cancellationToken);
        if (movieList is null)
            return Result<List<MovieModel>>.Failure(Error.NotFound);

        return Result<List<MovieModel>>.Ok(movieList);
    }
    public async Task<Result<MovieModel>> SearchByTitle(string title, CancellationToken cancellationToken = default)
    {
        var movie = await mediator.Send(new SearchByTitleQuery(title), cancellationToken);
        if (movie is null)
            return Result<MovieModel>.Failure(Error.NotFound);

        return Result<MovieModel>.Ok(movie);
    }

    public async Task<Result<List<MovieModel>>> SearchByDirector(string director, CancellationToken cancellationToken = default)
    {
        var movieList = await mediator.Send(new SearchByDirectorQuery(director), cancellationToken);
        if (movieList is null)
            return Result<List<MovieModel>>.Failure(Error.NotFound);

        return Result<List<MovieModel>>.Ok(movieList);
    }

    public async Task<Result<MovieModel>> SearchByReleaseDate(DateTime releaseDate, CancellationToken cancellationToken = default)
    {
        var movie = await mediator.Send(new SearchByReleaseDateQuery(releaseDate), cancellationToken);
        if (movie is null)
            return Result<MovieModel>.Failure(Error.NotFound);

        return Result<MovieModel>.Ok(movie);
    }
}