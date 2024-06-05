using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Races.DataModels;
using QuestForge.CharacterService.Core.Races.Entities;

namespace QuestForge.CharacterService.Core.Characters.Aggregates.Race;

public class RaceAggregate : ValueObject
{
    [JsonIgnore]
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public double Movement { get; private set; }
    public List<Feature> Features { get; private set; }

    public RaceAggregate(BaseDataModel dataModel) : base(dataModel)
    {
        var parsedDataModel = dataModel as RaceDataModel;

        Id = parsedDataModel!.Id;
        Name = parsedDataModel!.Name;
        Description = parsedDataModel.Description;
        Movement = parsedDataModel.Movement;
        Features = parsedDataModel.Features
            .Select(x => new Feature(x))
            .ToList();
    }
}