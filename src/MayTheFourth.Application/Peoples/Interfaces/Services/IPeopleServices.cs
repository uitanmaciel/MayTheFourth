using MayTheFourth.Application.Peoples.Responses;

namespace MayTheFourth.Application.Peoples.Interfaces.Services;

public interface IPeopleServices
{
    Task<Result<IList<PeopleResponse>>> GetPeoplesAsync(int? skip, int? take, CancellationToken cancellationToken = default);
    Task<Result<PeopleResponse>> GetPeopleByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<Result<IList<PeopleResponse>>> GetPeopleByNameAsync(string name, CancellationToken cancellationToken = default);
    Task<Result<IList<PeopleResponse>>> GetPeopleByGenderAsync(string gender, CancellationToken cancellationToken = default);
}