using QuestForge.CharacterService.Configuration;
using QuestForge.CharacterService.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services
    .ConfigureController()
    .ConfigureIoC(builder.Configuration)
    .ConfigureSwagger()
    .AddHealthChecks();

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app
    .UpdateMigrations()
    .ConfigureMiddleware()
    .UseHttpsRedirection()
    .UseRouting()
    .UseAuthentication()
    .UseAuthorization()
    .ConfigureEndpoints(builder.Configuration.GetSection("EndPointsConfig"));

app.Run();