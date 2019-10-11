namespace SonOfTabNav.Client.Features.Base.Components
{
  using BlazorState.Features.Routing;
  using BlazorState.Pipeline.ReduxDevTools;
  using SonOfTabNav.Client.Features.Application;
  using SonOfTabNav.Client.Features.Counter;
  using SonOfTabNav.Client.Features.EventStream;
  using SonOfTabNav.Client.Features.Tabs;
  using SonOfTabNav.Client.Features.WeatherForecast;

  /// <summary>
  /// Makes access to the State a little easier and by inheriting from
  /// BlazorStateDevToolsComponent it allows for ReduxDevTools operation.
  /// </summary>
  /// <remarks>
  /// In production one would NOT be required to use these base components
  /// But would be required to properly implement the required interfaces.
  /// one could conditionally inherit from BaseComponent for production build.
  /// </remarks>
  public class BaseComponent : BlazorStateDevToolsComponent
  {
    internal ApplicationState ApplicationState => GetState<ApplicationState>();
    internal CounterState CounterState => GetState<CounterState>();
    internal EventStreamState EventStreamState => GetState<EventStreamState>();
    internal RouteState RouteState => GetState<RouteState>();
    internal TabState TabState => GetState<TabState>();
    internal WeatherForecastsState WeatherForecastsState => GetState<WeatherForecastsState>();
  }
}