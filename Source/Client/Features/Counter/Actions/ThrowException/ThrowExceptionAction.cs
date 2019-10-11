namespace SonOfTabNav.Client.Features.Counter
{
  using SonOfTabNav.Client.Features.Base;

  internal partial class CounterState
  {
    public class ThrowExceptionAction : BaseAction
    {
      public string Message { get; set; }
    }
  }
}