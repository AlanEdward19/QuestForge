using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;
using QuestForge.CharacterService.Core.Races.DataModels;
using QuestForge.CharacterService.Core.Races.Entities;

namespace QuestForge.CharacterService.Application.Common.Features.Get;

public class GetFeatureQueryHandler(IRepository<FeatureDataModel> repository) : IHandler<GetFeatureQuery, Feature>
{
    public async Task<Feature> Handle(GetFeatureQuery command, CancellationToken cancellationToken)
    {
        FeatureDataModel featureDataModel = await repository.GetByIdAsync(command, cancellationToken);
        Feature feature = new(featureDataModel);

        return feature;
    }
}