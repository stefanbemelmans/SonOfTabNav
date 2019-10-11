namespace SonOfTabNav.Client.Features.Counter.Components
{
  using System.Threading.Tasks;
  using SonOfTabNav.Client.Features.Base.Components;
  using static SonOfTabNav.Client.Features.Counter.CounterState;

  public class CounterBase : BaseComponent
  {
    protected async Task ButtonClick() =>
      _ = await Mediator.Send(new IncrementCounterAction { Amount = 5 });
  }
}