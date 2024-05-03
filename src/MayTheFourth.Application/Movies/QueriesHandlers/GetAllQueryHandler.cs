using MayTheFourth.Application.Movies.Interfaces.State;
using MayTheFourth.Application.Movies.Queries;

namespace MayTheFourth.Application.Movies.QueriesHandlers;

public class GetAllQueryHandler(IMovieRepository repository) : IRequestHandler<GetAllQuery, IList<Movie>>
{
    public async Task<IList<Movie>> Handle(GetAllQuery request, CancellationToken cancellationToken)
        => await repository.GetAllAsync(request.Skip, request.Take, cancellationToken);
}