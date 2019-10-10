using System;
using AffinityOffsetUpdater;

namespace TestOffsets
{
    internal class Program
    {
       private static void Main()
       {
           var offsets = new Offsets();

            #region NETVARS
            Console.WriteLine("[NETVARS]" + Environment.NewLine);
            //Console.WriteLine(nameof(offsets.rootObject.netvars.) + ": " + offsets.rootObject.netvars.);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_ArmorValue) + ": " + offsets.rootObject.netvars.m_ArmorValue);
            Console.WriteLine(nameof(offsets.rootObject.netvars.cs_gamerules_data) + ": " + offsets.rootObject.netvars.cs_gamerules_data);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_Collision) + ": " + offsets.rootObject.netvars.m_Collision);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_CollisionGroup) + ": " + offsets.rootObject.netvars.m_CollisionGroup);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_Local) + ": " + offsets.rootObject.netvars.m_Local);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_MoveType) + ": " + offsets.rootObject.netvars.m_MoveType);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_OriginalOwnerXuidHigh) + ": " + offsets.rootObject.netvars.m_OriginalOwnerXuidHigh);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_OriginalOwnerXuidLow) + ": " + offsets.rootObject.netvars.m_OriginalOwnerXuidLow);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_SurvivalGameRuleDecisionTypes) + ": " + offsets.rootObject.netvars.m_SurvivalGameRuleDecisionTypes);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_SurvivalRules) + ": " + offsets.rootObject.netvars.m_SurvivalRules);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_aimPunchAngle) + ": " + offsets.rootObject.netvars.m_aimPunchAngle);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_aimPunchAngleVel) + ": " + offsets.rootObject.netvars.m_aimPunchAngleVel);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_bFreezePeriod) + ": " + offsets.rootObject.netvars.m_bFreezePeriod);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_bGunGameImmunity) + ": " + offsets.rootObject.netvars.m_bGunGameImmunity);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_bHasDefuser) + ": " + offsets.rootObject.netvars.m_bHasDefuser);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_bHasHelmet) + ": " + offsets.rootObject.netvars.m_bHasHelmet);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_bInReload) + ": " + offsets.rootObject.netvars.m_bInReload);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_bIsDefusing) + ": " + offsets.rootObject.netvars.m_bIsDefusing);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_bIsQueuedMatchmaking) + ": " + offsets.rootObject.netvars.m_bIsQueuedMatchmaking);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_bIsScoped) + ": " + offsets.rootObject.netvars.m_bIsScoped);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_bIsValveDS) + ": " + offsets.rootObject.netvars.m_bIsValveDS);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_bSpotted) + ": " + offsets.rootObject.netvars.m_bSpotted);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_bSpottedByMask) + ": " + offsets.rootObject.netvars.m_bSpottedByMask);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_clrRender) + ": " + offsets.rootObject.netvars.m_clrRender);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_dwBoneMatrix) + ": " + offsets.rootObject.netvars.m_dwBoneMatrix);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_fAccuracyPenalty) + ": " + offsets.rootObject.netvars.m_fAccuracyPenalty);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_fFlags) + ": " + offsets.rootObject.netvars.m_fFlags);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_flC4Blow) + ": " + offsets.rootObject.netvars.m_flC4Blow);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_flDefuseCountDown) + ": " + offsets.rootObject.netvars.m_flDefuseCountDown);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_flDefuseLength) + ": " + offsets.rootObject.netvars.m_flDefuseLength);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_flFallbackWear) + ": " + offsets.rootObject.netvars.m_flFallbackWear);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_flFlashDuration) + ": " + offsets.rootObject.netvars.m_flFlashDuration);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_flFlashMaxAlpha) + ": " + offsets.rootObject.netvars.m_flFlashMaxAlpha);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_flNextPrimaryAttack) + ": " + offsets.rootObject.netvars.m_flNextPrimaryAttack);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_flTimerLength) + ": " + offsets.rootObject.netvars.m_flTimerLength);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_hActiveWeapon) + ": " + offsets.rootObject.netvars.m_hActiveWeapon);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_hMyWeapons) + ": " + offsets.rootObject.netvars.m_hMyWeapons);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_hObserverTarget) + ": " + offsets.rootObject.netvars.m_hObserverTarget);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_hOwner) + ": " + offsets.rootObject.netvars.m_hOwner);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_hOwnerEntity) + ": " + offsets.rootObject.netvars.m_hOwnerEntity);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_iAccountID) + ": " + offsets.rootObject.netvars.m_iAccountID);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_iClip1) + ": " + offsets.rootObject.netvars.m_iClip1);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_iCompetitiveRanking) + ": " + offsets.rootObject.netvars.m_iCompetitiveRanking);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_iCompetitiveWins) + ": " + offsets.rootObject.netvars.m_iCompetitiveWins);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_iCrosshairId) + ": " + offsets.rootObject.netvars.m_iCrosshairId);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_iEntityQuality) + ": " + offsets.rootObject.netvars.m_iEntityQuality);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_iFOV) + ": " + offsets.rootObject.netvars.m_iFOV);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_iFOVStart) + ": " + offsets.rootObject.netvars.m_iFOVStart);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_iGlowIndex) + ": " + offsets.rootObject.netvars.m_iGlowIndex);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_iHealth) + ": " + offsets.rootObject.netvars.m_iHealth);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_iItemDefinitionIndex) + ": " + offsets.rootObject.netvars.m_iItemDefinitionIndex);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_iItemIDHigh) + ": " + offsets.rootObject.netvars.m_iItemIDHigh);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_iObserverMode) + ": " + offsets.rootObject.netvars.m_iObserverMode);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_iShotsFired) + ": " + offsets.rootObject.netvars.m_iShotsFired);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_iState) + ": " + offsets.rootObject.netvars.m_iState);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_iTeamNum) + ": " + offsets.rootObject.netvars.m_iTeamNum);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_lifeState) + ": " + offsets.rootObject.netvars.m_lifeState);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_bBombPlanted) + ": " + offsets.rootObject.netvars.m_bBombPlanted);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_nFallbackSeed) + ": " + offsets.rootObject.netvars.m_nFallbackSeed);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_nFallbackPaintKit) + ": " + offsets.rootObject.netvars.m_nFallbackPaintKit);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_nFallbackStatTrak) + ": " + offsets.rootObject.netvars.m_nFallbackStatTrak);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_nForceBone) + ": " + offsets.rootObject.netvars.m_nForceBone);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_nTickBase) + ": " + offsets.rootObject.netvars.m_nTickBase);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_rgflCoordinateFrame) + ": " + offsets.rootObject.netvars.m_rgflCoordinateFrame);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_szCustomName) + ": " + offsets.rootObject.netvars.m_szCustomName);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_szLastPlaceName) + ": " + offsets.rootObject.netvars.m_szLastPlaceName);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_thirdPersonViewAngles) + ": " + offsets.rootObject.netvars.m_thirdPersonViewAngles);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_vecOrigin) + ": " + offsets.rootObject.netvars.m_vecOrigin);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_vecVelocity) + ": " + offsets.rootObject.netvars.m_vecVelocity);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_vecViewOffset) + ": " + offsets.rootObject.netvars.m_vecViewOffset);
            Console.WriteLine(nameof(offsets.rootObject.netvars.m_viewPunchAngle) + ": " + offsets.rootObject.netvars.m_viewPunchAngle);
            Console.WriteLine(Environment.NewLine);
            #endregion

            #region SIGNATURES
            Console.WriteLine("[SIGNATURES]" + Environment.NewLine);
            //Console.WriteLine(nameof(offsets.rootObject.signatures.) + ": " + offsets.rootObject.signatures.);
            Console.WriteLine(Environment.NewLine);
            #endregion

            Console.ReadKey();
        }
    }
}
