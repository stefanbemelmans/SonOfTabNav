namespace SonOfTabNav.Client.Features.ClientLoaderFeature
{
  using System;

  public interface IClientLoaderConfiguration
  {
    TimeSpan DelayTimeSpan { get; }
  }
}
