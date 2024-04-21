using MayTheFourth.Application.Movies.Interfaces.State;
using MayTheFourth.Application.Movies.Queries;

namespace MayTheFourth.Application.Movies.QueriesHandlers;

public class SearchByTitleQueryHandler(IMovieRepository movieState) : IRequestHandler<SearchByTitleQuery, MovieModel>
{
    public async Task<MovieModel> Handle(SearchByTitleQuery request, CancellationToken cancellationToken)
        => await movieState.SearchByName(request.Name, cancellationToken);
}