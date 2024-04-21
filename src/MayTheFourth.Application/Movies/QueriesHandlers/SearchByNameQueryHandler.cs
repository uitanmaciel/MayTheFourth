using MayTheFourth.Application.Movies.Interfaces.State;
using MayTheFourth.Application.Movies.Queries;

namespace MayTheFourth.Application.Movies.QueriesHandlers;

public class SearchByNameQueryHandler(IMovieRepository movieState) : IRequestHandler<SearchByNameQuery, MovieModel>
{
    public async Task<MovieModel> Handle(SearchByNameQuery request, CancellationToken cancellationToken)
        => await movieState.SearchByName(request.Name, cancellationToken);
}