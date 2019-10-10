using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace AffinityOffsetUpdater
{
    public class Offsets
    { 
        public class Signatures
        {
            public int clientstate_choked_commands { get; set; }
            public int clientstate_delta_ticks { get; set; }
            public int clientstate_last_outgoing_command { get; set; }
            public int clientstate_net_channel { get; set; }
            public int convar_name_hash_table { get; set; }
            public int dwClientState { get; set; }
            public int dwClientState_GetLocalPlayer { get; set; }
            public int dwClientState_IsHLTV { get; set; }
            public int dwClientState_Map { get; set; }
            public int dwClientState_MapDirectory { get; set; }
            public int dwClientState_MaxPlayer { get; set; }
            public int dwClientState_PlayerInfo { get; set; }
            public int dwClientState_State { get; set; }
            public int dwClientState_ViewAngles { get; set; }
            public int dwEntityList { get; set; }
            public int dwForceAttack { get; set; }
            public int dwForceAttack2 { get; set; }
            public int dwForceBackward { get; set; }
            public int dwForceForward { get; set; }
            public int dwForceJump { get; set; }
            public int dwForceLeft { get; set; }
            public int dwForceRight { get; set; }
            public int dwGameDir { get; set; }
            public int dwGameRulesProxy { get; set; }
            public int dwGetAllClasses { get; set; }
            public int dwGlobalVars { get; set; }
            public int dwGlowObjectManager { get; set; }
            public int dwInput { get; set; }
            public int dwInterfaceLinkList { get; set; }
            public int dwLocalPlayer { get; set; }
            public int dwMouseEnable { get; set; }
            public int dwMouseEnablePtr { get; set; }
            public int dwPlayerResource { get; set; }
            public int dwRadarBase { get; set; }
            public int dwSensitivity { get; set; }
            public int dwSensitivityPtr { get; set; }
            public int dwSetClanTag { get; set; }
            public int dwViewMatrix { get; set; }
            public int dwWeaponTable { get; set; }
            public int dwWeaponTableIndex { get; set; }
            public int dwYawPtr { get; set; }
            public int dwZoomSensitivityRatioPtr { get; set; }
            public int dwbSendPackets { get; set; }
            public int dwppDirect3DDevice9 { get; set; }
            public int interface_engine_cvar { get; set; }
            public int find_hud_element { get; set; }
            public int m_bDormant { get; set; }
            public int m_pStudioHdr { get; set; }
            public int m_pitchClassPtr { get; set; }
            public int m_yawClassPtr { get; set; }
            public int model_ambient_min { get; set; }
        } 
    }
}
