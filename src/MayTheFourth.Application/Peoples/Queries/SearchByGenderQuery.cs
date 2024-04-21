namespace MayTheFourth.Application.Peoples.Queries;

public record SearchByGenderQuery(string Gender) : IRequest<PeopleModel>;
