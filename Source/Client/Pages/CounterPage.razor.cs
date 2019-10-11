namespace SonOfTabNav.Client.Pages
{
  using SonOfTabNav.Client.Features.Base.Components;
  using System.Linq;

  public class CounterPageBase : BaseComponent
  {
    public const string Route = "/counter";

    public string ActiveTab => RouteState.Route.Split('/').Last();

    public string InfoTabActive => ActiveTab == "counter" ? "active" : "";

  }
}
