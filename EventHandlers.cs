using Exiled.Events.EventArgs;
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
                if (Plugin.Singleton.Config.Hint)
                {
                    ev.Player.ShowHint(ClassBc, Plugin.Singleton.Config.BcTime);
                }
                else
                {
                    ev.Player.Broadcast(message: ClassBc, duration: Plugin.Singleton.Config.BcTime);
                }
            }
        }
    }
}
