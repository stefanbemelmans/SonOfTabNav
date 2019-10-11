﻿namespace SonOfTabNav.Client.Features.WeatherForecast
{
  using System.Collections.Generic;
  using SonOfTabNav.Api.Features.WeatherForecast;
  using BlazorState;

  internal partial class WeatherForecastsState : State<WeatherForecastsState>
  {
    private List<WeatherForecastDto> _WeatherForecasts;

    public IReadOnlyList<WeatherForecastDto> WeatherForecasts => _WeatherForecasts.AsReadOnly();

    public WeatherForecastsState()
    {
      _WeatherForecasts = new List<WeatherForecastDto>();
    }

    public override void Initialize() { }
  }
}