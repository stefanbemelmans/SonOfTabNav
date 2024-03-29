﻿namespace SonOfTabNav.Client.Features.Application
{
  using BlazorState;
  using MediatR;
  using System.Threading;
  using System.Threading.Tasks;
  using static BlazorState.Features.Routing.RouteState;
  using static SonOfTabNav.Client.Features.Application.ApplicationState;

  internal class ResetStoreHandler : IRequestHandler<ResetStoreAction>
  {
    private readonly IMediator Mediator;

    private readonly IStore Store;

    public ResetStoreHandler(IStore aStore, IMediator aMediator)
    {
      Mediator = aMediator;
      Store = aStore;
    }

    public async Task<Unit> Handle(ResetStoreAction aResetStoreAction, CancellationToken aCancellationToken)
    {
      Store.Reset();
      _ = await Mediator.Send(new ChangeRouteAction { NewRoute = "/" });
      return Unit.Value;
    }
  }
}