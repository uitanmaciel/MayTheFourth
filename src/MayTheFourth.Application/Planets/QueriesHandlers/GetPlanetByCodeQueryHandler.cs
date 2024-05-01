using MayTheFourth.Application.Planets.Interfaces.State;
using MayTheFourth.Application.Planets.Queries;

namespace MayTheFourth.Application.Planets.QueriesHandlers;

public class GetPlanetByCodeQueryHandler(IPlanetRepository repository) : IRequestHandler<GetPlanetByCodeQuery, Planet>
{
    public async Task<Planet> Handle(GetPlanetByCodeQuery request, CancellationToken cancellationToken)
        => await repository.GetPlanetByCodeAsync(request.Code, cancellationToken);
}