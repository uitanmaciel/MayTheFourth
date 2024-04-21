namespace MayTheFourth.Application.Movies.Queries;

public record SearchByNameQuery(string Name) : IRequest<MovieModel>;