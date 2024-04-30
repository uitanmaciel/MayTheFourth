namespace MayTheFourth.Application.Peoples.Interfaces.State;

public interface IPeopleRepository
{
    Task<IList<People>> GetPeoplesAsync(CancellationToken cancellationToken = default);
    Task<People> GetPeopleByCodeAsync(int code, CancellationToken cancellationToken = default);
    Task<IList<People>> GetPeopleByNameAsync(string name, CancellationToken cancellationToken = default);
    Task<IList<People>> GetPeopleByGenderAsync(string gender, CancellationToken cancellationToken = default);
}