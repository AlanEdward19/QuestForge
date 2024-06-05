using QuestForge.CharacterService.Core.Classes.DataModels;
using QuestForge.CharacterService.Core.Classes.Entities;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

namespace QuestForge.CharacterService.Application.Classes.Get;

public class GetClassQueryHandler(IRepository<ClassDataModel> repository) : IHandler<GetClassQuery, Class>
{
    public async Task<Class> Handle(GetClassQuery command, CancellationToken cancellationToken)
    {
        ClassDataModel classDataModel = await repository.GetByIdAsync(command, cancellationToken);

        return new Class(classDataModel);
    }
}