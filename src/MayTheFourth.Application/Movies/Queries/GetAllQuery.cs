namespace MayTheFourth.Application.Movies.Queries;

public record GetAllQuery(int? Skip, int? Take) : IRequest<IList<Movie>>;