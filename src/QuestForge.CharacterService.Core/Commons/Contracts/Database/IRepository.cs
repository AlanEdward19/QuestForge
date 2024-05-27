using QuestForge.CharacterService.Core.Commons.Abstracts;

namespace QuestForge.CharacterService.Core.Commons.Contracts.Database;

public interface IRepository<T> where T : class
{
    IUnitOfWork UnitOfWork { get; }
    
    public Task<T> GetByIdAsync(Query query, CancellationToken cancellationToken);
    public Task<IEnumerable<T>> GetAllAsync(Query query, CancellationToken cancellationToken);
    public Task<bool> AddAsync(Command command, CancellationToken cancellationToken);
    public Task<bool> UpdateAsync(Command command, CancellationToken cancellationToken);
    public Task<bool> DeleteAsync(Command command, CancellationToken cancellationToken);
}