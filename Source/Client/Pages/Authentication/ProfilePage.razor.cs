namespace TimeWarpCli.Pages
{
  using TimeWarpCli.Features.Bases;

  public partial class ProfilePage : BaseComponent
  {
    private const string RouteTemplate = "/Profile";

    public static string GetRoute() => RouteTemplate;
  }
}
