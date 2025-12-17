using MichelMichels.RuneScapeWiki.Models;

namespace MichelMichels.RuneScapeWiki.Core;

public interface IGrandExchangeClient
{
    Task<LatestResponse> GetLatest(CancellationToken token);
    Task<LatestResponse> GetLatest(int itemId, CancellationToken token);
}
