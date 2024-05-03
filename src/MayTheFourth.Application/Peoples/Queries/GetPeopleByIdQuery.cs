namespace MayTheFourth.Application.Peoples.Queries;

public record GetPeopleByIdQuery(int Id) : IRequest<People>;