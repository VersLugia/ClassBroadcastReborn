using Exiled.API.Features;
using Exiled.CreditTags;
using System;

namespace ClassBroadcast
{
    public class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "ClassBroadcast";
        public override string Author => "VersLugia";
        public override Version Version => new Version(1, 1, 0);
        public override Version RequiredExiledVersion => new Version(4, 0, 0);

        public static Plugin Singleton;
        private EventHandlers events;

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
            events = null;
            Singleton = null;
            base.OnDisabled();
        }
    }
}