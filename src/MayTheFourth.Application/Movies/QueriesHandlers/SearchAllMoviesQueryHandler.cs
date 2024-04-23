using MayTheFourth.Application.Movies.Interfaces.State;
using MayTheFourth.Application.Movies.Queries;
using MayTheFourth.Application.Movies;
using MayTheFourth.Application.Peoples.Interfaces.State;
using MayTheFourth.Application.Peoples;

public class SearchAllMoviesQueryHandler(IMovieRepository movieState) : IRequestHandler<SearchAllMoviesQuery, List<MovieModel>>
{
    public async Task<List<MovieModel>> Handle(SearchAllMoviesQuery request, CancellationToken cancellationToken)
        => await movieState.SearchAllMovies(cancellationToken);

}