using QuestForge.CharacterService.Core.Backgrounds.DataModels;
using QuestForge.CharacterService.Core.Backgrounds.Entities;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

namespace QuestForge.CharacterService.Application.Backgrounds.Traits.Get;

public class GetTraitQueryHandler(IRepository<TraitDataModel> repository) : IHandler<GetTraitQuery, Trait>
{
    public async Task<Trait> Handle(GetTraitQuery query, CancellationToken cancellationToken)
    {
        TraitDataModel traitDataModel = await repository.GetByIdAsync(query, cancellationToken);

        return new(traitDataModel);
    }
}