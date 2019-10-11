namespace SonOfTabNav.Client.Features.Application.Components
{
  using SonOfTabNav.Client.Features.Base.Components;

  public class SideBarBase: BaseComponent
  {
    protected string NavMenuCssClass => ApplicationState.IsMenuExpanded ? null : "collapse";
  }
}
  