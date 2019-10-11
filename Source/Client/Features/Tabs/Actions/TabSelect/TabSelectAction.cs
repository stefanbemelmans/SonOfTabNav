using BlazorState;
using SonOfTabNav.Client.Features.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SonOfTabNav.Client.Features.Tabs.TabState;

namespace SonOfTabNav.Client.Features.Tabs.Actions.TabSelect
{
  internal partial class TabState 
  {

    public class TabSelectAction : BaseAction
    {
        public Tab SelectedTab { get; set; }
    }
  }
}
