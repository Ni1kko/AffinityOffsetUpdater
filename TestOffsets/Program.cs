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
            Console.WriteLine(nameof(offsets.rootObject.signatures.clientstate_choked_commands) + ": " + offsets.rootObject.signatures.clientstate_choked_commands);
            Console.WriteLine(nameof(offsets.rootObject.signatures.clientstate_delta_ticks) + ": " + offsets.rootObject.signatures.clientstate_delta_ticks);
            Console.WriteLine(nameof(offsets.rootObject.signatures.clientstate_last_outgoing_command) + ": " + offsets.rootObject.signatures.clientstate_last_outgoing_command);
            Console.WriteLine(nameof(offsets.rootObject.signatures.clientstate_net_channel) + ": " + offsets.rootObject.signatures.clientstate_net_channel);
            Console.WriteLine(nameof(offsets.rootObject.signatures.convar_name_hash_table) + ": " + offsets.rootObject.signatures.convar_name_hash_table);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwClientState) + ": " + offsets.rootObject.signatures.dwClientState);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwClientState_GetLocalPlayer) + ": " + offsets.rootObject.signatures.dwClientState_GetLocalPlayer);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwClientState_IsHLTV) + ": " + offsets.rootObject.signatures.dwClientState_IsHLTV);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwClientState_Map) + ": " + offsets.rootObject.signatures.dwClientState_Map);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwClientState_MapDirectory) + ": " + offsets.rootObject.signatures.dwClientState_MapDirectory);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwClientState_MaxPlayer) + ": " + offsets.rootObject.signatures.dwClientState_MaxPlayer);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwClientState_PlayerInfo) + ": " + offsets.rootObject.signatures.dwClientState_PlayerInfo);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwClientState_State) + ": " + offsets.rootObject.signatures.dwClientState_State);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwClientState_ViewAngles) + ": " + offsets.rootObject.signatures.dwClientState_ViewAngles);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwEntityList) + ": " + offsets.rootObject.signatures.dwEntityList);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwForceAttack) + ": " + offsets.rootObject.signatures.dwForceAttack);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwForceAttack2) + ": " + offsets.rootObject.signatures.dwForceAttack2);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwForceBackward) + ": " + offsets.rootObject.signatures.dwForceBackward);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwForceForward) + ": " + offsets.rootObject.signatures.dwForceForward);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwForceJump) + ": " + offsets.rootObject.signatures.dwForceJump);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwForceLeft) + ": " + offsets.rootObject.signatures.dwForceLeft);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwForceRight) + ": " + offsets.rootObject.signatures.dwForceRight);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwGameDir) + ": " + offsets.rootObject.signatures.dwGameDir);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwGameRulesProxy) + ": " + offsets.rootObject.signatures.dwGameRulesProxy);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwGetAllClasses) + ": " + offsets.rootObject.signatures.dwGetAllClasses);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwGlobalVars) + ": " + offsets.rootObject.signatures.dwGlobalVars);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwGlowObjectManager) + ": " + offsets.rootObject.signatures.dwGlowObjectManager);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwInput) + ": " + offsets.rootObject.signatures.dwInput);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwInterfaceLinkList) + ": " + offsets.rootObject.signatures.dwInterfaceLinkList);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwLocalPlayer) + ": " + offsets.rootObject.signatures.dwLocalPlayer);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwMouseEnable) + ": " + offsets.rootObject.signatures.dwMouseEnable);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwMouseEnablePtr) + ": " + offsets.rootObject.signatures.dwMouseEnablePtr);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwPlayerResource) + ": " + offsets.rootObject.signatures.dwPlayerResource);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwRadarBase) + ": " + offsets.rootObject.signatures.dwRadarBase);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwSensitivity) + ": " + offsets.rootObject.signatures.dwSensitivity);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwSensitivityPtr) + ": " + offsets.rootObject.signatures.dwSensitivityPtr);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwSetClanTag) + ": " + offsets.rootObject.signatures.dwSetClanTag);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwViewMatrix) + ": " + offsets.rootObject.signatures.dwViewMatrix);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwWeaponTable) + ": " + offsets.rootObject.signatures.dwWeaponTable);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwWeaponTableIndex) + ": " + offsets.rootObject.signatures.dwWeaponTableIndex);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwYawPtr) + ": " + offsets.rootObject.signatures.dwYawPtr);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwZoomSensitivityRatioPtr) + ": " + offsets.rootObject.signatures.dwZoomSensitivityRatioPtr);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwbSendPackets) + ": " + offsets.rootObject.signatures.dwbSendPackets);
            Console.WriteLine(nameof(offsets.rootObject.signatures.dwppDirect3DDevice9) + ": " + offsets.rootObject.signatures.dwppDirect3DDevice9);
            Console.WriteLine(nameof(offsets.rootObject.signatures.interface_engine_cvar) + ": " + offsets.rootObject.signatures.interface_engine_cvar);
            Console.WriteLine(nameof(offsets.rootObject.signatures.find_hud_element) + ": " + offsets.rootObject.signatures.find_hud_element);
            Console.WriteLine(nameof(offsets.rootObject.signatures.m_bDormant) + ": " + offsets.rootObject.signatures.m_bDormant);
            Console.WriteLine(nameof(offsets.rootObject.signatures.m_pStudioHdr) + ": " + offsets.rootObject.signatures.m_pStudioHdr);
            Console.WriteLine(nameof(offsets.rootObject.signatures.m_pitchClassPtr) + ": " + offsets.rootObject.signatures.m_pitchClassPtr);
            Console.WriteLine(nameof(offsets.rootObject.signatures.m_yawClassPtr) + ": " + offsets.rootObject.signatures.m_yawClassPtr);
            Console.WriteLine(nameof(offsets.rootObject.signatures.model_ambient_min) + ": " + offsets.rootObject.signatures.model_ambient_min);
            Console.WriteLine(Environment.NewLine);
            #endregion

            Console.ReadKey();
        }
    }
}
