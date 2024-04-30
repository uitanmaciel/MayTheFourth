using MayTheFourth.Application.Movies.Interfaces.State;
using MayTheFourth.Application.Movies.Queries;

namespace MayTheFourth.Application.Movies.QueriesHandlers;

public class SearchByReleaseDateQueryHandler(IMovieRepository repository) : IRequestHandler<SearchByReleaseDateQuery, IList<Movie>>
{
    public async Task<IList<Movie>> Handle(SearchByReleaseDateQuery request, CancellationToken cancellationToken)
        => await repository.SearchByReleaseDateAsync(request.ReleaseDate, cancellationToken);
}