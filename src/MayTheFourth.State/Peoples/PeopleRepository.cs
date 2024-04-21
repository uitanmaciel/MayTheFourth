using MayTheFourth.Application.Peoples;
using MayTheFourth.Application.Peoples.Interfaces.State;

namespace MayTheFourth.State.Peoples;

public class PeopleRepository : IPeopleRepository
{
    public Task<List<PeopleModel>> ListAll(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PeopleModel> SearchByGender(string gender, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PeopleModel> SearchByHeight(string height, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PeopleModel> SearchById(int id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<PeopleModel> SearchByName(string name, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
