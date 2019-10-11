namespace SonOfTabNav.Client.Features.Counter
{
  using SonOfTabNav.Client.Features.Base;

  internal partial class CounterState
  {
    public class IncrementCounterAction : BaseAction
    {
      public int Amount { get; set; }
    }
  }
}