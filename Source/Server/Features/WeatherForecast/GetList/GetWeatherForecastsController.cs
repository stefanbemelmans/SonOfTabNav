namespace SonOfTabNav.Server.Features.WeatherForecast
{
  using System.Threading.Tasks;
  using SonOfTabNav.Server.Features.Base;
  using SonOfTabNav.Api.Features.WeatherForecast;
  using Microsoft.AspNetCore.Mvc;

  [Route(GetWeatherForecastsRequest.Route)]
  public class GetWeatherForecastsController : BaseController<GetWeatherForecastsRequest, GetWeatherForecastsResponse>
  {
    public async Task<IActionResult> Process(GetWeatherForecastsRequest aRequest) => await Send(aRequest);
  }
}