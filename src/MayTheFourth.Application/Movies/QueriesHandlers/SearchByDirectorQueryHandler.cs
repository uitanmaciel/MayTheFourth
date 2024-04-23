using MayTheFourth.Application.Movies.Interfaces.State;
using MayTheFourth.Application.Movies.Queries;

namespace MayTheFourth.Application.Movies.QueriesHandlers;

public class SearchByDirectorQueryHandler(IMovieRepository movieState) : IRequestHandler<SearchByDirectorQuery, List<MovieModel>>
{
    public async Task<List<MovieModel>> Handle(SearchByDirectorQuery request, CancellationToken cancellationToken)
        => await movieState.SearchByDirector(request.Director, cancellationToken);
}