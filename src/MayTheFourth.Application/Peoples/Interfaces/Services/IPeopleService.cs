namespace MayTheFourth.Application.Peoples.Interfaces.Services;

public interface IPeopleService
{
    Task<Result<PeopleModel>> SearchByName(string name, CancellationToken cancellationToken = default);
    Task<Result<PeopleModel>> SearchByGender(string gender, CancellationToken cancellationToken = default);
    Task<Result<PeopleModel>> SearchByHeight(string height, CancellationToken cancellationToken = default);
    Task<Result<PeopleModel>> SearchById(int id, CancellationToken cancellationToken = default);
    Task<Result<List<PeopleModel>>> ListAll(CancellationToken cancellationToken = default);
}

