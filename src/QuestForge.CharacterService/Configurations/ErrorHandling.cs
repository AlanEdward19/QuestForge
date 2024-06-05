using QuestForge.CharacterService.Middlewares;

namespace QuestForge.CharacterService.Configuration;

public static class ErrorHandling
{
    public static IApplicationBuilder ConfigureMiddleware(this IApplicationBuilder app)
    {
        app.UseMiddleware<ExceptionMiddleware>();

        return app;
    }
}