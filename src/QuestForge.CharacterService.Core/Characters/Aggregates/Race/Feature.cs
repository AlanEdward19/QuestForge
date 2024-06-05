using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Races.DataModels;

namespace QuestForge.CharacterService.Core.Characters.Aggregates.Race;

public class Feature : ValueObject
{
    public string Name { get; private set; }
    public string Description { get; private set; }

    public Feature(BaseDataModel dataModel) : base(dataModel)
    {
        var parsedDataModel = dataModel as FeatureDataModel;

        Name = parsedDataModel.Name;
        Description = parsedDataModel.Description;
    }
}