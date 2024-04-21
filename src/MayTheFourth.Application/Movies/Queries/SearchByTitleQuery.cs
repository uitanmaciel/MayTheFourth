namespace MayTheFourth.Application.Movies.Queries;

public record SearchByTitleQuery(string Name) : IRequest<MovieModel>;