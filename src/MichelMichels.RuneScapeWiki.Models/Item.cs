using System.Text.Json.Serialization;

namespace MichelMichels.RuneScapeWiki.Models;

public class Item
{
    [JsonPropertyName("examine")]
    public string Examine { get; set; } = string.Empty;

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("members")]
    public bool IsMembersOnly { get; set; }

    [JsonPropertyName("lowalch")]
    public int LowAlchemyValue { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }

    [JsonPropertyName("highalch")]
    public int HighAlchemyValue { get; set; }

    [JsonPropertyName("icon")]
    public string IconName { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}
