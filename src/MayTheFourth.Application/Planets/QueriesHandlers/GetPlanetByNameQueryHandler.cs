using MayTheFourth.Application.Planets.Interfaces.State;
using MayTheFourth.Application.Planets.Queries;

namespace MayTheFourth.Application.Planets.QueriesHandlers;

public class GetPlanetByNameQueryHandler(IPlanetRepository repository) : IRequestHandler<GetPlanetByNameQuery, IList<Planet>>
{
    public async Task<IList<Planet>> Handle(GetPlanetByNameQuery request, CancellationToken cancellationToken)
        => await repository.GetPlanetByNameAsync(request.Name, cancellationToken);
}