using BlazorState;
using MediatR;
using SonOfTabNav.Client.Features.Base;
using System.Threading;
using System.Threading.Tasks;
using static SonOfTabNav.Client.Features.Tabs.Actions.TabSelect.TabState;

namespace SonOfTabNav.Client.Features.Tabs
{
  internal partial class TabState
  {
    public class TabSelectHandler : BaseHandler<TabSelectAction>
    {
      public TabSelectHandler(IStore aStore) : base(aStore)
      {
      }

      public override  Task<Unit> Handle
        (
        TabSelectAction aTabSelectAction,
        CancellationToken aCancellationToken
        )
      {
        TabState.CurrentTab = aTabSelectAction.SelectedTab;

        return Unit.Task;
      }
    }
  }
}