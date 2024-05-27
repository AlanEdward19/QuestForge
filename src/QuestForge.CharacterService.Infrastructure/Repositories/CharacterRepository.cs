namespace QuestForge.CharacterService.Infrastructure.Repositories;

public class CharacterRepository(IUnitOfWork unitOfWork) : IRepository<CharacterDataModel>
{
    public IUnitOfWork UnitOfWork { get; } = unitOfWork;
    
    public Task<CharacterDataModel> GetByIdAsync(Query query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CharacterDataModel>> GetAllAsync(Query query, CancellationToken cancellationToken)
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