using MichelMichels.RuneScapeWiki.Enums;

namespace MichelMichels.RuneScapeWiki.Helpers;

public static class ApiEndpointConverter
{
    private const string _apiBaseEndpoint = "/api/v1";

    public static string GetUrl(ApiEndpoint endpoint)
    {
        return endpoint switch
        {
            ApiEndpoint.OldSchoolRuneScape => $"{_apiBaseEndpoint}/osrs",
            ApiEndpoint.DeadmanArmageddon => $"{_apiBaseEndpoint}/dmm",
            _ => throw new NotSupportedException()
        };
    }
}
