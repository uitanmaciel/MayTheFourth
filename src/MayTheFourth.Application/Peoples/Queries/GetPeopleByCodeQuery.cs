namespace MayTheFourth.Application.Peoples.Queries;

public record GetPeopleByCodeQuery(int Code) : IRequest<People>;