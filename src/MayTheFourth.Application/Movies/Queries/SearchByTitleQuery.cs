namespace MayTheFourth.Application.Movies.Queries;

public record SearchByTitleQuery(string Title) : IRequest<IList<Movie>>;