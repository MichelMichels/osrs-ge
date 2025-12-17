using MichelMichels.RuneScapeWiki.Enums;

namespace MichelMichels.RuneScapeWiki;

public class GrandExchangeClientOptions
{
    public string BaseUrl { get; set; } = "https://prices.runescape.wiki";
    public ApiEndpoint Endpoint { get; set; } = ApiEndpoint.OldSchoolRuneScape;
    public string UserAgent { get; set; } = "MichelMichels.RuneScapeWiki/0.1 (+https://github.com/MichelMichels/osrs-ge)";

    public static GrandExchangeClientOptions Default => new();
}
