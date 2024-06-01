FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["QuestForge.CharacterService/QuestForge.CharacterService.csproj", "QuestForge.CharacterService/"]
COPY ["QuestForge.ServiceDefaults/QuestForge.ServiceDefaults.csproj", "QuestForge.ServiceDefaults/"]
COPY ["QuestForge.CharacterService.Infrastructure/QuestForge.CharacterService.Infrastructure.csproj", "QuestForge.CharacterService.Infrastructure/"]
COPY ["QuestForge.CharacterService.Core/QuestForge.CharacterService.Core.csproj", "QuestForge.CharacterService.Core/"]
COPY ["QuestForge.CharacterService.Application/QuestForge.CharacterService.Application.csproj", "QuestForge.CharacterService.Application/"]
RUN dotnet restore "QuestForge.CharacterService/QuestForge.CharacterService.csproj"
COPY . .
WORKDIR "/src/QuestForge.CharacterService"
RUN dotnet build "QuestForge.CharacterService.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "QuestForge.CharacterService.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "QuestForge.CharacterService.dll"]
