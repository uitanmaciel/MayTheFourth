namespace MayTheFourth.Application.Peoples.Queries;

public record SearchByNameQuery(string Name) : IRequest<PeopleModel>;
