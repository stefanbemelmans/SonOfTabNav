namespace SonOfTabNav.Client.Features.Base.Components
{
  using BlazorState.Pipeline.ReduxDevTools;
  using SonOfTabNav.Client.Features.Application;
  using SonOfTabNav.Client.Features.Counter;
  using SonOfTabNav.Client.Features.WeatherForecast;
  using SonOfTabNav.Client.Features.EventStream;
  using SonOfTabNav.Client.Features.Tabs;

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
    internal WeatherForecastsState WeatherForecastsState => GetState<WeatherForecastsState>();
    internal TabState TabState => GetState<TabState>();
  
  }
}