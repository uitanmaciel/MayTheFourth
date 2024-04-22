using MayTheFourth.Application.Movies.Interfaces.State;
using MayTheFourth.Application.Movies.Queries;
using MayTheFourth.Application.Movies;

public class SearchAllMoviesQueryHandler(IMovieRepository movieState) : IRequestHandler<SearchAllMoviesQuery, MovieModel>
{
    public async Task<MovieModel> Handle(SearchAllMoviesQuery request, CancellationToken cancellationToken)
        => await movieState.SearchAllMovies(cancellationToken);

}