using System.ComponentModel;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace BetterReforges
{
    [Label("First Try Config")]
    public class BetterReforgesConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        public static BetterReforgesConfig Instance;

        public enum accessoryType
        {
            All,
            Warding,
            Menacing,
            Quick,
            Lucky,
            Arcane
        }

        [Header("Accessory Reforge Type")]
        [Label("Reforge")]
        [DefaultValue(accessoryType.All)]
        [DrawTicks]
        public accessoryType chosenType;
    }
}