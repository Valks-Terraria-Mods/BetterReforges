using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace FirstTry
{
    class Reforge : GlobalItem
    {
        static int[] accessoryModifiers = { PrefixID.Warding, PrefixID.Menacing, PrefixID.Quick, PrefixID.Lucky, PrefixID.Arcane };
        static int[] mageModifiers = { PrefixID.Mythical };
        static int[] meleeModifiers = { PrefixID.Legendary };
        static int[] rangeModifiers = { PrefixID.Unreal };
        static int[] summonerModifiers = { PrefixID.Mythical };
        static int[] toolModifiers = { PrefixID.Light };
        static int[] thrownModifiers = { PrefixID.Legendary };

        public override int ChoosePrefix(Item item, UnifiedRandom rand) {
            if (item.accessory) {
                int index = rand.Next(0, accessoryModifiers.Length);
                return accessoryModifiers[index];
            }

            if (item.melee) {
                int index = rand.Next(0, meleeModifiers.Length);
                return meleeModifiers[index];
            }

            if (item.ranged) {
                int index = rand.Next(0, rangeModifiers.Length);
                return rangeModifiers[index];
            }

            if (item.summon) {
                int index = rand.Next(0, summonerModifiers.Length);
                return summonerModifiers[index];
            }

            if (item.thrown) {
                int index = rand.Next(0, thrownModifiers.Length);
                return thrownModifiers[index];
            }

            return PrefixID.Light;
        }

        /*
         * public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }
        */
    }
}
