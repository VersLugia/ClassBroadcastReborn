using Exiled.Events.EventArgs;
using MEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBroadcast
{
    class EventHandlers
    {
        public void OnPlayerChangeRole(ChangingRoleEventArgs ev)
        {
            if (Plugin.Singleton.Config.Class_Bc.TryGetValue(ev.NewRole, out string ClassBc))
            {
                if (Plugin.Singleton.Config.BroadcastType.Contains("Broadcast"))
                {
                    ev.Player.Broadcast(Plugin.Singleton.Config.BcTime, ClassBc);
                }
                else if (Plugin.Singleton.Config.BroadcastType.Contains("Window"))
                {
                    Timing.CallDelayed(1f, () => ev.Player.OpenReportWindow(ClassBc));
                }
                else
                {
                    ev.Player.ShowHint(ClassBc, Plugin.Singleton.Config.BcTime);
                }
            }
        }
    }
}
