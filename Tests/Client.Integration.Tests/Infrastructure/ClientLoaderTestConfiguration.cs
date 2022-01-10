namespace TimeWarpCli.Client.Integration.Tests.Infrastructure
{
  using System;
  using TimeWarpCli.Features.ClientLoaders;

  [NotTest]
  public class ClientLoaderTestConfiguration : IClientLoaderConfiguration
  {
    public TimeSpan DelayTimeSpan => TimeSpan.FromMilliseconds(10);
  }
}
