using System.Text.Json.Serialization;

namespace MichelMichels.RuneScapeWiki.Models;

public class AveragePricingData
{
    [JsonPropertyName("avgHighPrice")]
    public int? AverageHighPrice { get; set; }

    [JsonPropertyName("highPriceVolume")]
    public int? HighPriceVolume { get; set; }

    [JsonPropertyName("avgLowPrice")]
    public int? AverageLowPrice { get; set; }

    [JsonPropertyName("lowPriceVolume")]
    public int? LowPriceVolume { get; set; }
}
