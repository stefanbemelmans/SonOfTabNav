﻿namespace SonOfTabNav.Client.Features.EventStream.Components
{
  using System.Collections.Generic;
  using SonOfTabNav.Client.Features.Base.Components;

  public class EventStreamBase : BaseComponent
  {
    public IReadOnlyList<string> Events => EventStreamState.Events;
  }
}
