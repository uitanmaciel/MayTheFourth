namespace MayTheFourth.Application.Peoples.Queries;

public record SearchByIdQuery(int Id) : IRequest<PeopleModel>;
