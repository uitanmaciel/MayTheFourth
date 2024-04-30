namespace MayTheFourth.Application.Movies.Queries;

public record SearchByProducerQuery(string Producer) : IRequest<IList<Movie>>;