using QuestForge.CharacterService.Application.Characters.Get;
using QuestForge.CharacterService.Core.Characters.Aggregates;
using QuestForge.CharacterService.Core.Characters.DataModels;
using QuestForge.CharacterService.Core.Characters.Services;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

namespace QuestForge.CharacterService.Application.Characters.List;

public class ListCharacterQueryHandler(IRepository<CharacterDataModel> repository) : IHandler<ListCharacterQuery, IEnumerable<CharacterAggregateRoot>>
{
    public async Task< IEnumerable<CharacterAggregateRoot>> Handle(ListCharacterQuery command, CancellationToken cancellationToken)
    {
        IEnumerable<CharacterDataModel> charactersDataModel= await repository.GetAllAsync(command, cancellationToken);
        List<CharacterAggregateRoot> characters = new List<CharacterAggregateRoot>(charactersDataModel.Count());

        foreach (var characterDataModel in charactersDataModel)
        {
            CharacterAggregateRoot character = CharacterCreationService.CreateCharacterBasedOnDataModel(characterDataModel);
            characters.Add(character);
        }

        return characters;
    }
}