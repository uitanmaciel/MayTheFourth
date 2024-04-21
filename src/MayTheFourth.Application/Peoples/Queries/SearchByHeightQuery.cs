namespace MayTheFourth.Application.Peoples.Queries;

public record SearchByHeightQuery(string Height) : IRequest<PeopleModel>;
