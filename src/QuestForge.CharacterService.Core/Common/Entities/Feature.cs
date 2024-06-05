using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Races.DataModels;

namespace QuestForge.CharacterService.Core.Common.Entities;

public class Feature: ValueObject
{
    [JsonIgnore]
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }

    public Feature(BaseDataModel dataModel) : base(dataModel)
    {
        var parsedDataModel = dataModel as FeatureDataModel;

        Id = parsedDataModel!.Id;
        Name = parsedDataModel.Name;
        Description = parsedDataModel.Description;
    }

    public void UpdateName(string? name)
    {
        if (!string.IsNullOrWhiteSpace(name) && !Name.Equals(name))
            Name = name;
    }

    public void UpdateDescription(string? description)
    {
        if (!string.IsNullOrWhiteSpace(description) && !Description.Equals(description))
            Description = description;
    }

    public FeatureDataModel ToDataModel()
    {
        return new FeatureDataModel(Id, Name, Description);
    }
}