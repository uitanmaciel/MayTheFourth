using MayTheFourth.Application.Peoples.Responses;

namespace MayTheFourth.Application.Peoples.Interfaces.Services;

public interface IPeopleServices
{
    Task<Result<IList<PeopleResponse>>> GetPeoplesAsync(CancellationToken cancellationToken = default);
    Task<Result<PeopleResponse>> GetPeopleByCodeAsync(int code, CancellationToken cancellationToken = default);
    Task<Result<IList<PeopleResponse>>> GetPeopleByNameAsync(string name, CancellationToken cancellationToken = default);
    Task<Result<IList<PeopleResponse>>> GetPeopleByGenderAsync(string gender, CancellationToken cancellationToken = default);
}