namespace MayTheFourth.Application.Peoples.Queries;

public record GetPeopleByGenderQuery(string Gender) : IRequest<IList<People>>;