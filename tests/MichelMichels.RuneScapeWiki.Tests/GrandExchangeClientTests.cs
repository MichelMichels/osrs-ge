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
    public async Task GetLatest_Cancellation_Test()
    {
        // Arrange
        GrandExchangeClient context = new();
        CancellationTokenSource cts = new();
        CancellationToken token = cts.Token;

        // Act
        cts.Cancel();

        // Assert
        await Assert.ThrowsAsync<OperationCanceledException>(() => context.GetLatest(token));
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

    [TestMethod]
    public async Task GetMapping_Test()
    {
        // Arrange
        GrandExchangeClient context = new();

        // Act
        MappingResponse result = await context.GetMapping(CancellationToken.None);

        // Assert
        Assert.IsGreaterThan(0, result.Count);
    }

    [TestMethod]
    public async Task GetFiveMinuteAverage_Test()
    {
        // Arrange
        GrandExchangeClient context = new();

        // Act
        AveragesResponse result = await context.GetFiveMinuteAverage(CancellationToken.None);

        // Assert
        Assert.IsGreaterThan(0, result.Data.Count);
    }

    [TestMethod]
    public async Task GetOneHourAverage_Test()
    {
        // Arrange
        GrandExchangeClient context = new();

        // Act
        AveragesResponse result = await context.GetOneHourAverage(CancellationToken.None);

        // Assert
        Assert.IsGreaterThan(0, result.Data.Count);
    }

    [TestMethod]
    public async Task GetTimeSeries_Test()
    {
        // Arrange
        GrandExchangeClient context = new();

        // Act
        TimeSeriesResponse result = await context.GetTimeSeries(4151, TimeSteps.OneDay, CancellationToken.None);

        // Assert
        Assert.IsGreaterThan(0, result.Data.Count);
    }
}
