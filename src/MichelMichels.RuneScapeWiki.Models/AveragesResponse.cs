using System.Text.Json.Serialization;

namespace MichelMichels.RuneScapeWiki.Models;

public class AveragesResponse
{
    [JsonPropertyName("data")]
    public Dictionary<string, AveragePricingData> Data { get; set; } = [];

    [JsonPropertyName("timestamp")]
    public int Timestamp { get; set; }
}
