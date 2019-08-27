using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace BetterReforges
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
        static int[] noKnockbackModifiers = { PrefixID.Demonic};

        public override int ChoosePrefix(Item item, UnifiedRandom rand) {
            if (item.accessory)
            {
                int index = rand.Next(0, accessoryModifiers.Length);
                return accessoryModifiers[index];
            }

            if (item.maxStack == 0 || item.damage > 0 || item.useStyle != 0) {
                if (item.melee)
                {
                    if ( item.knockBack > 0 )
                    {
                        int index = rand.Next(0, meleeModifiers.Length);
                        return meleeModifiers[index];
                    }
                    else
                    {
                        int index = rand.Next(0, noKnockbackModifiers.Length);
                        return noKnockbackModifiers[index];
                    }
                }

                if (item.ranged)
                {
                    if (item.knockBack > 0)
                    {
                        int index = rand.Next(0, rangeModifiers.Length);
                        return rangeModifiers[index];
                    }
                    else
                    {
                        int index = rand.Next(0, noKnockbackModifiers.Length);
                        return noKnockbackModifiers[index];
                    }
                }

                if (item.magic)
                {
                    if ( item.knockBack > 0 )
                    {
                        int index = rand.Next(0, mageModifiers.Length);
                        return mageModifiers[index];
                    } 
                    else
                    {
                        int index = rand.Next(0, noKnockbackModifiers.Length);
                        return noKnockbackModifiers[index];
                    }
                }

                if (item.summon)
                {
                    int index = rand.Next(0, summonerModifiers.Length);
                    return summonerModifiers[index];
                }

                if (item.thrown)
                {
                    int index = rand.Next(0, thrownModifiers.Length);
                    return thrownModifiers[index];
                }

                if (item.hammer > 0 || item.pick > 0 || item.axe > 0)
                {
                    int index = rand.Next(0, toolModifiers.Length);
                    return thrownModifiers[index];
                }
            }

            return -1;
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
