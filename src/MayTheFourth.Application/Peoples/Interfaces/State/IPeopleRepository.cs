namespace MayTheFourth.Application.Peoples.Interfaces.State;

public interface IPeopleRepository
{
    Task<PeopleModel> SearchByName(string name, CancellationToken cancellationToken = default);
    Task<PeopleModel> SearchByGender(string gender, CancellationToken cancellationToken = default);
    Task<PeopleModel> SearchByHeight(string height, CancellationToken cancellationToken = default);
    Task<PeopleModel> SearchById(int id, CancellationToken cancellationToken = default);
    Task<List<PeopleModel>> ListAll(CancellationToken cancellationToken = default);
}
