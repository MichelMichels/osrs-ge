using System.Text.Json.Serialization;

namespace MichelMichels.RuneScapeWiki.Models;

public class TimeSeriesResponse
{
    [JsonPropertyName("data")]
    public List<TimeSeriesAveragePricingData> Data { get; set; } = [];

    [JsonPropertyName("itemId")]
    public int ItemId { get; set; }
}
