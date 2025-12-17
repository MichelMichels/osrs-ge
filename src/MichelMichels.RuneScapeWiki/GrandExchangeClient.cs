using MichelMichels.RuneScapeWiki.Core;
using MichelMichels.RuneScapeWiki.Helpers;
using MichelMichels.RuneScapeWiki.Models;
using System.Diagnostics;
using System.Text.Json;

namespace MichelMichels.RuneScapeWiki;

public class GrandExchangeClient : IGrandExchangeClient
{
    private readonly GrandExchangeClientOptions options;

    private HttpClient? _httpClient;

    public GrandExchangeClient() : this(GrandExchangeClientOptions.Default) { }
    public GrandExchangeClient(GrandExchangeClientOptions options)
    {
        this.options = options ?? throw new ArgumentNullException(nameof(options));
    }

    public async Task<LatestResponse> GetLatest(CancellationToken token)
    {
        return await Get<LatestResponse>("/latest", token);
    }
    public async Task<LatestResponse> GetLatest(int id, CancellationToken token)
    {
        return await Get<LatestResponse>($"/latest?id={id}", token);
    }

    private async Task<T> Get<T>(string endpoint, CancellationToken token)
    {
        token.ThrowIfCancellationRequested();
        HttpClient client = GetOrCreateHttpClient();

        token.ThrowIfCancellationRequested();
        string requestUri = BuildUri(endpoint);
        HttpResponseMessage response = await client.GetAsync(requestUri, token);

        if (!response.IsSuccessStatusCode)
        {
            throw new NotSupportedException();
        }

        string json = await response.Content.ReadAsStringAsync(token);
#if DEBUG
        Debug.WriteLine(json);
#endif

        return JsonSerializer.Deserialize<T>(json) ?? throw new NotSupportedException();
    }

    private string BuildUri(string value)
    {
        return ApiEndpointConverter.GetUrl(options.Endpoint) + value;
    }
    private HttpClient GetOrCreateHttpClient()
    {
        if (_httpClient is not null)
        {
            return _httpClient;
        }

        _httpClient = new HttpClient()
        {
            BaseAddress = new Uri(options.BaseUrl),
        };
        _httpClient.DefaultRequestHeaders.Add("User-Agent", options.UserAgent);

        return _httpClient;
    }
}
