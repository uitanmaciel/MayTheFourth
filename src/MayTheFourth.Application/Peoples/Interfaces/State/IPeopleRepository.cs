namespace MayTheFourth.Application.Peoples.Interfaces.State;

public interface IPeopleRepository
{
    Task<IList<People>> GetPeoplesAsync(int? skip, int? take, CancellationToken cancellationToken = default);
    Task<People> GetPeopleByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<IList<People>> GetPeopleByNameAsync(string name, CancellationToken cancellationToken = default);
    Task<IList<People>> GetPeopleByGenderAsync(string gender, CancellationToken cancellationToken = default);
}