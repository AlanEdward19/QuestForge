namespace QuestForge.CharacterService.Infrastructure.Repositories;

public class RaceRepository(IUnitOfWork unitOfWork) : IRepository<RaceDataModel>
{
    public IUnitOfWork UnitOfWork { get; } = unitOfWork;

    public Task<RaceDataModel> GetByIdAsync(Query query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<RaceDataModel>> GetAllAsync(Query query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AddAsync(Command command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(Command command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(Command command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}