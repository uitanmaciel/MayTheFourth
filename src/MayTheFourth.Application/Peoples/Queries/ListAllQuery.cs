namespace MayTheFourth.Application.Peoples.Queries;

public record ListAllQuery() : IRequest<List<PeopleModel>>;
