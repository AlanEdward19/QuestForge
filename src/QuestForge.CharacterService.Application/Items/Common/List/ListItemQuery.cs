﻿using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Items.Enums;

namespace QuestForge.CharacterService.Application.Items.Common.List;

public class ListItemQuery : Query
{
    public EItemType Type { get; set; }
}