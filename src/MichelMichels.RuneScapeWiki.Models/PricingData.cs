using System.Text.Json.Serialization;

namespace MichelMichels.RuneScapeWiki.Models;

public class PricingData
{
    [JsonPropertyName("high")]
    public int? High { get; set; }

    [JsonPropertyName("highTime")]
    public int? HighTime { get; set; }

    [JsonPropertyName("low")]
    public int? Low { get; set; }

    [JsonPropertyName("lowTime")]
    public int? LowTime { get; set; }
}
