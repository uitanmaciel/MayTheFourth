using MayTheFourth.Application.Movies.Interfaces.State;
using MayTheFourth.Application.Movies.Queries;

namespace MayTheFourth.Application.Movies.QueriesHandlers;

public class SearchByReleaseDateQueryHandler(IMovieRepository movieState) : IRequestHandler<SearchByReleaseDateQuery, MovieModel>
{
    public async Task<MovieModel> Handle(SearchByReleaseDateQuery request, CancellationToken cancellationToken)
        => await movieState.SearchByReleaseDate(request.ReleaseDate, cancellationToken);
}