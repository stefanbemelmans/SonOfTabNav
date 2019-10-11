namespace SonOfTabNav.Client.Features.Base
{
  using BlazorState;
  using SonOfTabNav.Client.Features.Application;
  using SonOfTabNav.Client.Features.Counter;
  using SonOfTabNav.Client.Features.EventStream;
  using SonOfTabNav.Client.Features.Tabs;
  using SonOfTabNav.Client.Features.WeatherForecast;

  /// <summary>
  /// Base Handler that makes it easy to access state
  /// </summary>
  /// <typeparam name="TAction"></typeparam>
  internal abstract class BaseHandler<TAction> : ActionHandler<TAction>
    where TAction : IAction
  {
    protected ApplicationState ApplicationState => Store.GetState<ApplicationState>();

    protected CounterState CounterState => Store.GetState<CounterState>();

    protected EventStreamState EventStreamState => Store.GetState<EventStreamState>();

    protected WeatherForecastsState WeatherForecastsState => Store.GetState<WeatherForecastsState>();

    protected TabState TabState => Store.GetState<TabState>();
    public BaseHandler(IStore aStore) : base(aStore) { }
  }
}