using MayTheFourth.Application.Movies.Interfaces.State;
using MayTheFourth.Application.Movies.Queries;

namespace MayTheFourth.Application.Movies.QueriesHandlers;

public class SearchByDirectorQueryHandler(IMovieRepository repository) : IRequestHandler<SearchByDirectorQuery, IList<Movie>>
{
    public async Task<IList<Movie>> Handle(SearchByDirectorQuery request, CancellationToken cancellationToken)
        => await repository.SearchByDirectorAsync(request.Director, cancellationToken);
}