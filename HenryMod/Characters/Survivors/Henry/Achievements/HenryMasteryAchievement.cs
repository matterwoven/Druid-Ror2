using RoR2;
using DruidMod.Modules.Achievements;

namespace DruidMod.Survivors.Druid.Achievements
{
    //automatically creates language tokens "ACHIEVMENT_{identifier.ToUpper()}_NAME" and "ACHIEVMENT_{identifier.ToUpper()}_DESCRIPTION" 
    [RegisterAchievement(identifier, unlockableIdentifier, null, 10, null)]
    public class DruidMasteryAchievement : BaseMasteryAchievement
    {
        public const string identifier = DruidSurvivor.Druid_PREFIX + "masteryAchievement";
        public const string unlockableIdentifier = DruidSurvivor.Druid_PREFIX + "masteryUnlockable";

        public override string RequiredCharacterBody => DruidSurvivor.instance.bodyName;

        //difficulty coeff 3 is monsoon. 3.5 is typhoon for grandmastery skins
        public override float RequiredDifficultyCoefficient => 3;
    }
}