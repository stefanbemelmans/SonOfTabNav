﻿namespace SonOfTabNav.Client.Integration.Tests.Infrastructure
{
  using BlazorState;
  using Microsoft.AspNetCore.Blazor.Hosting;
  using Microsoft.Extensions.DependencyInjection;
  using System;
  using System.Reflection;
  using System.Text.Json;
  using SonOfTabNav.Client;
  using SonOfTabNav.Client.Features.Application;
  using SonOfTabNav.Client.Features.ClientLoaderFeature;
  using SonOfTabNav.Client.Features.Counter;
  using SonOfTabNav.Client.Features.EventStream;
  using SonOfTabNav.Client.Features.WeatherForecast;

  /// <summary>
  /// A known starting state(baseline) for all tests.
  /// And Common set of functions
  /// </summary>
  public class TestFixture//: IMediatorFixture, IStoreFixture, IServiceProviderFixture
  {
    private readonly TestServer BlazorStateTestServer;

    /// <summary>
    /// This is the ServiceProvider that will be used by the Client
    /// </summary>
    public IServiceProvider ServiceProvider => WebAssemblyHostBuilder.Build().Services;

    public IWebAssemblyHostBuilder WebAssemblyHostBuilder { get; }

    public TestFixture(TestServer aBlazorStateTestServer)
    {
      BlazorStateTestServer = aBlazorStateTestServer;
      WebAssemblyHostBuilder = BlazorWebAssemblyHost.CreateDefaultBuilder()
          .ConfigureServices(ConfigureServices);
    }

    /// <summary>
    /// Special configuration for Testing with the Test Server
    /// </summary>
    /// <param name="aServiceCollection"></param>
    private void ConfigureServices(IServiceCollection aServiceCollection)
    {
      aServiceCollection.AddSingleton(BlazorStateTestServer.CreateClient());
      aServiceCollection.AddBlazorState
      (
        aOptions => aOptions.Assemblies =
        new Assembly[] { typeof(Startup).GetTypeInfo().Assembly }
      );

      aServiceCollection.AddSingleton
      (
        new JsonSerializerOptions
        {
          PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        }
      );

      aServiceCollection.AddSingleton<IClientLoaderConfiguration, ClientLoaderTestConfiguration>();
      aServiceCollection.AddTransient<ApplicationState>();
      aServiceCollection.AddTransient<CounterState>();
      aServiceCollection.AddTransient<EventStreamState>();
      aServiceCollection.AddTransient<WeatherForecastsState>();
    }
  }
}