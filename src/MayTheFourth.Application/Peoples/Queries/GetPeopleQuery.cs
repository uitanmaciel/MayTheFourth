namespace MayTheFourth.Application.Peoples.Queries;

public record GetPeopleQuery(int? Skip, int? Take) : IRequest<IList<People>>;