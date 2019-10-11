namespace SonOfTabNav.Client.Features.Application.Components
{
  using SonOfTabNav.Client.Features.Base.Components;
  using static SonOfTabNav.Client.Features.Application.ApplicationState;

  public class NavBarBase : BaseComponent
  {
    protected string NavMenuCssClass => ApplicationState.IsMenuExpanded ? null : "collapse";

    protected async void ToggleNavMenu() => await Mediator.Send(new ToggleMenuAction());
  }
}