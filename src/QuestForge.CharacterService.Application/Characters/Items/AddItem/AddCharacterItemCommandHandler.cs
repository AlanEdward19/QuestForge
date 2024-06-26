﻿using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Characters.DataModels;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

namespace QuestForge.CharacterService.Application.Characters.Items.AddItem;

public class AddCharacterItemCommandHandler(IRepository<CharacterItemDataModel> repository)
    : IHandler<AddCharacterItemCommand, DatabaseOperationViewModel>
{
    public async Task<DatabaseOperationViewModel> Handle(AddCharacterItemCommand command,
        CancellationToken cancellationToken)
    {
        await repository.UnitOfWork.StartAsync(cancellationToken);

        await repository.AddAsync(command, cancellationToken);

        await repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        await repository.UnitOfWork.CommitAsync(cancellationToken);

        return new($"Item: '{command.ItemId}' given to character: '{command.CharacterId}' successfully!");
    }
}