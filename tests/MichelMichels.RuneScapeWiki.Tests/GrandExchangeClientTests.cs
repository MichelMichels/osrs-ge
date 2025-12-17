using MichelMichels.RuneScapeWiki.Models;

namespace MichelMichels.RuneScapeWiki.Tests;

[TestClass]
public sealed class GrandExchangeClientTests
{
    [TestMethod]
    public async Task GetLatest_Test()
    {
        // Arrange
        GrandExchangeClient context = new();

        // Act
        LatestResponse result = await context.GetLatest(CancellationToken.None);

        // Assert
        Assert.IsGreaterThan(0, result.Data.Count);
    }

    [TestMethod]
    public async Task GetLatest_AbyssalWhip_Test()
    {
        // Arrange
        GrandExchangeClient context = new();

        // Act
        int abyssalWhipItemId = 4151;
        LatestResponse result = await context.GetLatest(abyssalWhipItemId, CancellationToken.None);

        // Assert
        Assert.IsGreaterThan(0, result.Data.Count);
        Assert.HasCount(1, result.Data);
        Assert.IsNotNull(result.Data["4151"].HighTime);
        Assert.IsNotNull(result.Data["4151"].High);
        Assert.IsNotNull(result.Data["4151"].LowTime);
        Assert.IsNotNull(result.Data["4151"].Low);
    }
}
