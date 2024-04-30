namespace MayTheFourth.Application.Peoples.Queries;

public record GetPeopleByNameQuery(string Name) : IRequest<IList<People>>;