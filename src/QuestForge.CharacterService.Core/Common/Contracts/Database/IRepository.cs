using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Core.Common.Contracts.Database;

public interface IRepository<T> where T : class
{
    IUnitOfWork UnitOfWork { get; }

    public Task<T> GetByIdAsync(Query query, CancellationToken cancellationToken);
    public Task<IEnumerable<T>> GetAllAsync(Query query, CancellationToken cancellationToken);
    public Task AddAsync(Command command, CancellationToken cancellationToken);
    public Task UpdateAsync(Command command, CancellationToken cancellationToken);
    public Task DeleteAsync(Command command, CancellationToken cancellationToken);
}