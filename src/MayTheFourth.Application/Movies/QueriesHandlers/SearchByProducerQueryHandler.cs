using MayTheFourth.Application.Movies.Interfaces.State;
using MayTheFourth.Application.Movies.Queries;

namespace MayTheFourth.Application.Movies.QueriesHandlers;

public class SearchByProducerQueryHandler(IMovieRepository movieState) : IRequestHandler<SearchByProducerQuery, MovieModel>
{
    public async Task<MovieModel> Handle(SearchByProducerQuery request, CancellationToken cancellationToken)
        => await movieState.SearchByTitle(request.Producer, cancellationToken);
}