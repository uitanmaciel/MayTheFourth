namespace MayTheFourth.Application.Movies.Queries;

public record SearchByReleaseDateQuery(DateTime ReleaseDate) : IRequest<MovieModel>;