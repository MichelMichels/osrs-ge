# RuneScape Wiki GE C# client

[![NuGet Version](https://img.shields.io/nuget/v/MichelMichels.RuneScapeWiki)](https://www.nuget.org/packages/MichelMichels.RuneScapeWiki)

A C# wrapper for the RuneScape wiki real-time prices of the Grand Exchange.

## Intro

This C# libary wraps the REST API of [prices.runescape.wiki](https://prices.runescape.wiki/) 
with an opinionated client. Please read [the official documentation](https://oldschool.runescape.wiki/w/RuneScape:Real-time_Prices) 
for guidance about rate limiting.

## Quick start

```csharp
// Put these usings at the top of your file
using MichelMichels.RuneScapeWiki;
using MichelMichels.RuneScapeWiki.Models;

// Setup client
GrandExchangeClient context = new();

// Response
LatestResponse result = await context.GetLatest(CancellationToken.None);
```

## REST calls mapping

This table explains the connection between the REST API call and this library's implementation.

|REST|C#|
|---|---|
|`/api/v1/latest`|`GetLatest(...)`|
|`/api/v1/mapping`|`GetMapping(...)`|
|`/api/v1/5m`|`GetFiveMinuteAverage(...)`|
|`/api/v1/1h`|`GetOneHourAverage(...)`|
|`/api/v1/timeseries`|`GetTimeSeries(...)`|

Every method supports cancellation through `CancellationToken`s.