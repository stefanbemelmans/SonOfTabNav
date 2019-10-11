namespace SonOfTabNav.Client.Features.Base.Components
{
  using static SonOfTabNav.Client.Features.Application.ApplicationState;

  public class ResetButtonBase : BaseComponent
  {
    internal void ButtonClick() => Mediator.Send(new ResetStoreAction());
  }
}