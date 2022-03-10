using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace ClassBroadcastReborn
{
    public class Config : IConfig
    {
        [Description("Is enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Broadcast, Hint or Window (if not the correct type, it will hint)")]
        public BroadcastType BroadcastType { get; set; } = BroadcastType.Hint;

        [Description("the time you want bc or hint to be")]
        public ushort BcTime { get; set; } = 7;

        [Description("Set class bc text")]
        public Dictionary<RoleType, string> ClassBc { get; set; } = new Dictionary<RoleType, string>
        {
            [RoleType.ClassD] = "<color=#EE7600>Dboiiiiii</color>",
            [RoleType.Scp049] = "You are <color=#318504>Doctor</color>",
            [RoleType.Scp173] = "Haha matthew goes brrrr",
        };
    }
}