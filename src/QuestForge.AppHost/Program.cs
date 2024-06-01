var builder = DistributedApplication.CreateBuilder(args);

//var apiService = builder.AddProject<Projects.>("apiservice");

//builder.AddProject<Projects.QuestForge_Web>("webfrontend")
//    .WithExternalHttpEndpoints()
//    .WithReference(apiService);

//builder.AddProject<Projects.QuestForge_CharacterService>("questforge-characterservice");

builder.Build().Run();
