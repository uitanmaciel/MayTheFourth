using MayTheFourth.Application.Movies.Interfaces.State;
using MayTheFourth.Application.Movies.Queries;

namespace MayTheFourth.Application.Movies.QueriesHandlers;

public class SearchByTitleQueryHandler(IMovieRepository repository) : IRequestHandler<SearchByTitleQuery, IList<Movie>>
{
    public async Task<IList<Movie>> Handle(SearchByTitleQuery request, CancellationToken cancellationToken)
        => await repository.SearchByTitleAsync(request.Title, cancellationToken);
}