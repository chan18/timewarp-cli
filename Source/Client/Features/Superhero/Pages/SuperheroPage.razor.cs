namespace TimeWarpCli.Pages
{
  using System.Threading.Tasks;
  using TimeWarpCli.Features.Bases;
  using static TimeWarpCli.Features.Superheros.SuperheroState;

  public partial class SuperheroPage : BaseComponent
  {
    private const string RouteTemplate = "/Superheros";
    public static string GetRoute() => RouteTemplate;

    protected override async Task OnInitializedAsync() => await Send(new FetchSuperheroAction()).ConfigureAwait(false);
  }
}
