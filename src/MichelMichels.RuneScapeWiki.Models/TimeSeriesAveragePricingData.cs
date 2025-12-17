
using System.Text.Json.Serialization;

namespace MichelMichels.RuneScapeWiki.Models;

public class TimeSeriesAveragePricingData : AveragePricingData
{
    [JsonPropertyName("timestamp")]
    public int Timestamp { get; set; }
}
