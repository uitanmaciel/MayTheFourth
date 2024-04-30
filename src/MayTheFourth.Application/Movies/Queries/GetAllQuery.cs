namespace MayTheFourth.Application.Movies.Queries;

public record GetAllQuery() : IRequest<IList<Movie>>;