namespace QuestForge.CharacterService.Infrastructure.Repositories;

public class ClassRepository(IUnitOfWork unitOfWork) : IRepository<ClassDataModel>
{
    public IUnitOfWork UnitOfWork { get; } = unitOfWork;

    public Task<ClassDataModel> GetByIdAsync(Query query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ClassDataModel>> GetAllAsync(Query query, CancellationToken cancellationToken)
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