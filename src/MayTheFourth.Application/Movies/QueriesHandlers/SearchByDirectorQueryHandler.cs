using MayTheFourth.Application.Movies.Interfaces.State;
using MayTheFourth.Application.Movies.Queries;

namespace MayTheFourth.Application.Movies.QueriesHandlers;

public class SearchByDirectorQueryHandler(IMovieRepository movieState) : IRequestHandler<SearchByDirectorQuery, MovieModel>
{
    public async Task<MovieModel> Handle(SearchByDirectorQuery request, CancellationToken cancellationToken)
        => await movieState.SearchByTitle(request.Director, cancellationToken);
}