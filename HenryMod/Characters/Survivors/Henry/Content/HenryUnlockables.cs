using DruidMod.Survivors.Druid.Achievements;
using RoR2;
using UnityEngine;

namespace DruidMod.Survivors.Druid
{
    public static class DruidUnlockables
    {
        public static UnlockableDef characterUnlockableDef = null;
        public static UnlockableDef masterySkinUnlockableDef = null;

        public static void Init()
        {
            masterySkinUnlockableDef = Modules.Content.CreateAndAddUnlockbleDef(
                DruidMasteryAchievement.unlockableIdentifier,
                Modules.Tokens.GetAchievementNameToken(DruidMasteryAchievement.identifier),
                DruidSurvivor.instance.assetBundle.LoadAsset<Sprite>("texMasteryAchievement"));
        }
    }
}
