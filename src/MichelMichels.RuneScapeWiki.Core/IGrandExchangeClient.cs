using MichelMichels.RuneScapeWiki.Models;

namespace MichelMichels.RuneScapeWiki.Core;

public interface IGrandExchangeClient
{
    Task<LatestResponse> GetLatest(CancellationToken token);
    Task<LatestResponse> GetLatest(int itemId, CancellationToken token);
    Task<MappingResponse> GetMapping(CancellationToken token);
    Task<AveragesResponse> GetFiveMinuteAverage(CancellationToken token);
    Task<AveragesResponse> GetFiveMinuteAverage(int timestamp, CancellationToken token);
    Task<AveragesResponse> GetOneHourAverage(CancellationToken token);
    Task<AveragesResponse> GetOneHourAverage(int timestamp, CancellationToken token);
    Task<TimeSeriesResponse> GetTimeSeries(int itemId, string timestep, CancellationToken token);
}
