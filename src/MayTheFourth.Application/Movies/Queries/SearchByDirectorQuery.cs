namespace MayTheFourth.Application.Movies.Queries;

public record SearchByDirectorQuery(string Director) : IRequest<List<MovieModel>>;