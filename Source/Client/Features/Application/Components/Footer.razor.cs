namespace SonOfTabNav.Client.Features.Application.Components
{
  using SonOfTabNav.Client.Features.Base.Components;

  public class FooterBase: BaseComponent
  {
    protected string Version => ApplicationState.Version;
  }
}
