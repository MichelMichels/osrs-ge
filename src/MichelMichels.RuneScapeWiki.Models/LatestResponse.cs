using System.Text.Json.Serialization;

namespace MichelMichels.RuneScapeWiki.Models;

public class LatestResponse
{
    [JsonPropertyName("data")]
    public Dictionary<string, PricingData> Data { get; set; } = [];
}
