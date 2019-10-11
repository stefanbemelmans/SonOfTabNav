namespace SonOfTabNav.EndToEnd.Tests.Infrastructure
{
  using SonOfTabNav.Client.Features.ClientLoaderFeature;
  using System;

  public class TestClientLoaderConfiguration : IClientLoaderConfiguration
  {
    public TimeSpan DelayTimeSpan => TimeSpan.FromMilliseconds(10);
  }
}
