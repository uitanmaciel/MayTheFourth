using MayTheFourth.Application.Planets.Interfaces.State;
using MayTheFourth.Application.Planets.Queries;

namespace MayTheFourth.Application.Planets.QueriesHandlers;

public class GetPlanetsQueryHandler(IPlanetRepository repository) : IRequestHandler<GetPlanetsQuery, IList<Planet>>
{
    public async Task<IList<Planet>> Handle(GetPlanetsQuery request, CancellationToken cancellationToken)
        => await repository.GetPlanetsAsync(request.Skip, request.Take, cancellationToken);
}