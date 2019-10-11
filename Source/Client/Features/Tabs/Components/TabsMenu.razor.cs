namespace SonOfTabNav.Client.Features.Tabs.Components
{
  using Microsoft.AspNetCore.Components.Web;
  using SonOfTabNav.Client.Features.Base.Components;
  using System;
  using System.Collections.Generic;
  using static SonOfTabNav.Client.Features.Tabs.Actions.TabSelect.TabState;

  public class TabsMenuBase : BaseComponent
  {
    public List<Tab> TabList => TabState.TabList;

    public void OnTabSelect(Tab clickedTab)
    {
      Console.WriteLine("Selected a Tab ", clickedTab.ToString()  );

      Mediator.Send(new TabSelectAction { SelectedTab = clickedTab }); 
    }
  }
}