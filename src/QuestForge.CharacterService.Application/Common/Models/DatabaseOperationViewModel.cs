namespace QuestForge.CharacterService.Application.Common.Models;

public class DatabaseOperationViewModel(string message)
{
    public string Message { get; set; } = message;
}