using System.ComponentModel;
using Microsoft.OpenApi.Models;

namespace QuestForge.CharacterService.Configuration;

public static class Swagger
{
    public static IServiceCollection ConfigureSwagger(this IServiceCollection services)
    {
        services
            .AddEndpointsApiExplorer()
            .AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "CharacterService.API",
                    Version = "v1",
                    Description = """
                                  CharacterService é uma solução completa para a criação e gestão de personagens de Dungeons & Dragons 5ª Edição, 
                                  permitindo que os usuários criem personagens detalhados com todas as classes, raças e itens conforme as regras do Livro do Jogador de D&D 5e. 
                                  Além de oferecer ferramentas para atualização e gerenciamento contínuo de níveis, 
                                  experiência, habilidades e itens, o serviço permite a exportação de fichas de personagens em formatos padrão para fácil 
                                  utilização durante as sessões de jogo. Utilizando o Entity Framework Core, 
                                  CharacterService assegura o armazenamento e gerenciamento seguro dos dados dos personagens em um banco de dados relacional, 
                                  oferecendo uma interface intuitiva que simplifica o processo de criação e manutenção de personagens para jogadores e mestres.
                                  """
                });

                // c.OperationFilter<IgnorePropertiesOperationFilter>();

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header usando o esquema Bearer."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] { }
                    }
                });

                c.CustomSchemaIds(x =>
                    x.GetCustomAttributes(false).OfType<DisplayNameAttribute>().FirstOrDefault()?.DisplayName ??
                    x.Name);

#if DEBUG
                Directory.GetFiles("./Configurations/Comments/", "*.xml", SearchOption.TopDirectoryOnly).ToList()
                    .ForEach(xml => c.IncludeXmlComments(xml));
#endif
            });

        return services;
    }
}