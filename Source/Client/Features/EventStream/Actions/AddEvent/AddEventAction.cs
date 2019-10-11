namespace SonOfTabNav.Client.Features.EventStream
{
  using SonOfTabNav.Client.Features.Base;

  internal partial class EventStreamState
  {
    public class AddEventAction : BaseAction
    {
      public string Message { get; set; }
    }
  }
}