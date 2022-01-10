namespace TimeWarpCli.EndToEnd.Tests.Infrastructure
{
  using System;
  using TimeWarpCli.Features.ClientLoaders;

  public class TestClientLoaderConfiguration : IClientLoaderConfiguration
  {
    public TimeSpan DelayTimeSpan => TimeSpan.FromMilliseconds(10);
  }
}
