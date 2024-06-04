using System.Text.Json.Serialization;
using System.Text.Json;

namespace QuestForge.CharacterService.Core.Utils.Converters;

public class EnumListToStringListConverter<T> : JsonConverter<List<T>> where T : Enum
{
    public override List<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return null;
    }

    public override void Write(Utf8JsonWriter writer, List<T> value, JsonSerializerOptions options)
    {
        var stringList = value.Select(v => v.ToString()).ToList();
        JsonSerializer.Serialize(writer, stringList, options);
    }
}
