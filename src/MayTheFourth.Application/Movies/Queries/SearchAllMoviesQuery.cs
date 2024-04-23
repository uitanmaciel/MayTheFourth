using MayTheFourth.Application.Peoples;

namespace MayTheFourth.Application.Movies.Queries;

public record SearchAllMoviesQuery() : IRequest<List<MovieModel>>;
