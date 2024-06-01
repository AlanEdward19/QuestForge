using QuestForge.CharacterService.Core.Characters.Aggregates;
using QuestForge.CharacterService.Core.Characters.Services;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;
using QuestForge.CharacterService.Core.Common.DataModels;

namespace QuestForge.CharacterService.Application.Characters.Get;

public class GetCharacterQueryHandler(IRepository<CharacterDataModel> repository) : IHandler<GetCharacterQuery, CharacterAggregateRoot>
{
    public async Task<CharacterAggregateRoot> Handle(GetCharacterQuery command, CancellationToken cancellationToken)
    {
        CharacterDataModel characterDataModel = await repository.GetByIdAsync(command, cancellationToken);

        CharacterAggregateRoot character = CharacterCreationService.CreateCharacterBasedOnDataModel(characterDataModel);

        return character;
    }
}