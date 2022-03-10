using Exiled.API.Features;
using Exiled.CreditTags;
using System;

namespace ClassBroadcastReborn
{
    public class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "ClassBroadcastReborn";
        public override string Author => "VersLugia (original An4r3w)";
        public override Version Version => new Version(1, 2, 0);
        public override Version RequiredExiledVersion => new Version(5, 0, 0);

        public static Plugin Singleton;
        EventHandlers events;

        public override void OnEnabled()
        {
            Singleton = this;
            events = new EventHandlers();
            Exiled.Events.Handlers.Player.ChangingRole += events.OnPlayerChangeRole;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.ChangingRole -= events.OnPlayerChangeRole;
            Singleton = null;
            events = null;
            base.OnDisabled();
        }
    }
}