namespace SonOfTabNav.Client
{
  using BlazorState;
  using MediatR;
  using Microsoft.AspNetCore.Components.Builder;
  using Microsoft.Extensions.DependencyInjection;
  using System.Reflection;
  using SonOfTabNav.Client.Features.Application;
  using SonOfTabNav.Client.Features.ClientLoaderFeature;
  using SonOfTabNav.Client.Features.Counter;
  using SonOfTabNav.Client.Features.EventStream;
  using SonOfTabNav.Client.Features.WeatherForecast;
  using SonOfTabNav.Client.Features.Tabs;

  public class Startup
  {
    public void Configure(IComponentsApplicationBuilder aComponentsApplicationBuilder) =>
      aComponentsApplicationBuilder.AddComponent<App>("app");

    public void ConfigureServices(IServiceCollection aServiceCollection)
    {
      aServiceCollection.AddBlazorState
      (
        (aOptions) => aOptions.Assemblies =
          new Assembly[]
          {
            typeof(Startup).GetTypeInfo().Assembly,
          }
      );

      aServiceCollection.AddScoped(typeof(IPipelineBehavior<,>), typeof(EventStreamBehavior<,>));
      aServiceCollection.AddScoped<ClientLoader>();
      aServiceCollection.AddScoped<IClientLoaderConfiguration, ClientLoaderConfiguration>();

      aServiceCollection.AddTransient<ApplicationState>();
      aServiceCollection.AddTransient<CounterState>();
      aServiceCollection.AddTransient<EventStreamState>();
      aServiceCollection.AddTransient<WeatherForecastsState>();
      aServiceCollection.AddTransient<TabState>();
    }
  }
}