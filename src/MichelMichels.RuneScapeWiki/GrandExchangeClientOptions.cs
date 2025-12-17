namespace MichelMichels.RuneScapeWiki;

public class GrandExchangeClientOptions
{
    public string BaseUrl { get; set; } = "https://prices.runescape.wiki";
    public string Endpoint { get; set; } = GrandExchangeEndpoints.OldSchoolRuneScape;
    public string UserAgent { get; set; } = "MichelMichels.RuneScapeWiki/1.0 (+https://github.com/MichelMichels/osrs-ge)";

    public static GrandExchangeClientOptions Default => new();
}
