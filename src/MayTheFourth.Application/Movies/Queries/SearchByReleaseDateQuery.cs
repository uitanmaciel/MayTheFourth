namespace MayTheFourth.Application.Movies.Queries;

public record SearchByReleaseDateQuery(string ReleaseDate) : IRequest<IList<Movie>>;