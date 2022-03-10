using System;
using Exiled.Events.EventArgs;
using MEC;
using UnityEngine;

namespace ClassBroadcastReborn
{
    class EventHandlers
    {
        public void OnPlayerChangeRole(ChangingRoleEventArgs ev)
        {
            if (Plugin.Singleton.Config.ClassBc.TryGetValue(ev.NewRole, out string text))
            {
                switch (Plugin.Singleton.Config.BroadcastType)
                {
                    default: ev.Player.ShowHint(text, Plugin.Singleton.Config.BcTime); break;
                    case BroadcastType.Broadcast: ev.Player.Broadcast(Plugin.Singleton.Config.BcTime, text); break;
                    case BroadcastType.Hint: ev.Player.ShowHint(text, Plugin.Singleton.Config.BcTime); break;
                    case BroadcastType.Window: Timing.CallDelayed(0.5f, () => ev.Player.OpenReportWindow(text)); break;
                }
            }
        }
    }
}