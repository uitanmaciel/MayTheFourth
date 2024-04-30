namespace MayTheFourth.Application.Peoples.Queries;

public record GetPeopleQuery() : IRequest<IList<People>>;