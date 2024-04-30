using MayTheFourth.Application.Movies.Interfaces.State;
using MayTheFourth.Application.Movies.Queries;

namespace MayTheFourth.Application.Movies.QueriesHandlers;

public class SearchByProducerQueryHandler(IMovieRepository repository) : IRequestHandler<SearchByProducerQuery, IList<Movie>>
{
    public async Task<IList<Movie>> Handle(SearchByProducerQuery request, CancellationToken cancellationToken)
        => await repository.SearchByProducerAsync(request.Producer, cancellationToken);
}