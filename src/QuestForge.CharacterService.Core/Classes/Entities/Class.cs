using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.DataModels;

namespace QuestForge.CharacterService.Core.Classes.Entities;

public class Class : ValueObject
{
    [JsonIgnore]
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int HitDie { get; private set; }

    public Class(BaseDataModel dataModel) : base(dataModel)
    {
        var parsedDataModel = dataModel as ClassDataModel;
        
        Id = parsedDataModel!.Id;
        Name = parsedDataModel.Name;
        Description = parsedDataModel.Description;
        HitDie = parsedDataModel.HitDie;
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
    
    public void UpdateHitDie(int? hitDie)
    {
        if (hitDie != null && !HitDie.Equals(hitDie))
            HitDie = hitDie.Value;
    }
}