namespace SonOfTabNav.Client.Features.Tabs
{
  using BlazorState;
  using System.Collections.Generic;

  public class Tab
  {
    public string Content { get; set; }
    public string Title { get; set; }
  }

  internal partial class TabState : State<TabState>
  {
    public List<Tab> TabList = new List<Tab>
    {
      new Tab
      {
        Title = "Menu1",
        Content = "Menu1 Content"
      },
      new Tab
      {
        Title = "Menu2",
        Content = "Menu2 Content"
      },
      new Tab
      {
        Title = "Menu3",
        Content = "Menu3 Content"
      }
    };

    public Tab CurrentTab { get; set; }

    public TabState()
    {
    }

    public override void Initialize() => CurrentTab = TabList[0];
  }
}