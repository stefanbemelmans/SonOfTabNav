namespace SonOfTabNav.Client.Pages
{
  using System.Threading.Tasks;
  using SonOfTabNav.Client.Features.Base.Components;
  using static SonOfTabNav.Client.Features.WeatherForecast.WeatherForecastsState;

  public class WeatherForecastsPageBase : BaseComponent
  {
    public const string Route = "/weatherforecasts";

    protected override async Task OnInitializedAsync() =>
      await Mediator.Send(new FetchWeatherForecastsAction());
  }
}