using MayTheFourth.Application.Movies.Interfaces.Services;
using MayTheFourth.Application.Movies.Queries;
using MayTheFourth.Application.Movies.Responses;

namespace MayTheFourth.Application.Movies.Services;

public sealed class MovieService(ISender mediator) : IMovieService
{
    public async Task<Result<IList<MovieResponse>>> SearchByTitleAsync(string title, CancellationToken cancellationToken = default)
    {
        var movies = await mediator.Send(new SearchByTitleQuery(title), cancellationToken);
        if (movies is null)
            return Result<IList<MovieResponse>>.Failure(Error.NotFound);

        return Result<IList<MovieResponse>>.Ok(Movie.ToResponse(movies));
    }

    public async Task<Result<IList<MovieResponse>>> SearchByDirectorAsync(string director, CancellationToken cancellationToken = default)
    {
        var movies = await mediator.Send(new SearchByDirectorQuery(director), cancellationToken);
        if (movies is null)
            return Result<IList<MovieResponse>>.Failure(Error.NotFound);
        
        return Result<IList<MovieResponse>>.Ok(Movie.ToResponse(movies));
    }

    public async Task<Result<IList<MovieResponse>>> SearchByProducerAsync(string producer, CancellationToken cancellationToken = default)
    {
        var movies = await mediator.Send(new SearchByProducerQuery(producer), cancellationToken);
        if (movies is null)
            return Result<IList<MovieResponse>>.Failure(Error.NotFound);
        
        return Result<IList<MovieResponse>>.Ok(Movie.ToResponse(movies));
    }

    public async Task<Result<IList<MovieResponse>>> SearchByReleaseDateAsync(string releaseDate, CancellationToken cancellationToken = default)
    {
        var movies = await mediator.Send(new SearchByReleaseDateQuery(releaseDate), cancellationToken);
        if (movies is null)
            return Result<IList<MovieResponse>>.Failure(Error.NotFound);
        
        return Result<IList<MovieResponse>>.Ok(Movie.ToResponse(movies));
    }

    public async Task<Result<IList<MovieResponse>>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var movies = await mediator.Send(new GetAllQuery(), cancellationToken);
        if (movies is null)
            return Result<IList<MovieResponse>>.Failure(Error.NotFound);
        
        return Result<IList<MovieResponse>>.Ok(Movie.ToResponse(movies));
    }
}