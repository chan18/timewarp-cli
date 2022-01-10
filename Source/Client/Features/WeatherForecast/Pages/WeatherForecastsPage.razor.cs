namespace TimeWarpCli.Pages
{
  using System.Threading.Tasks;
  using TimeWarpCli.Features.Bases;
  using static TimeWarpCli.Features.WeatherForecasts.WeatherForecastsState;

  public partial class WeatherForecastsPage : BaseComponent
  {
    private const string RouteTemplate = "/WeatherForecasts";

    public static string GetRoute() => RouteTemplate;

    protected override async Task OnInitializedAsync() =>
      await Send(new FetchWeatherForecastsAction()).ConfigureAwait(false);
  }
}
