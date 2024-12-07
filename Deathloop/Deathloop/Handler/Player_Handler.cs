using CustomPlayerEffects;
using PlayerRoles;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using PluginAPI.Events;

namespace Deathloop.Handler;
public class Player_Handler
{
    [PluginEvent(ServerEventType.PlayerUseItem)]
    private static void OnPlayerUsingItem(PlayerUsedItemEvent ev)
    {
        if (ev.Item.ItemTypeId is ItemType.SCP500)
        {
            ev.Player.EffectsManager.DisableAllEffects();
        }
        else if (ev.Player.EffectsManager.GetEffect<Scp1344>() && ev.Player.EffectsManager.GetEffect<SeveredEyes>()) 
        {
            ev.Player.EffectsManager.EnableEffect<Scp1344>();
        }
    }

    [PluginEvent(ServerEventType.PlayerChangeRole)]
    private static void OnPlayerChangeRole(PlayerChangeRoleEvent ev)
    {
        if (ev.ChangeReason is RoleChangeReason.RemoteAdmin or RoleChangeReason.None)
            ev.Player.IsGodModeEnabled = ev.NewRole == RoleTypeId.Tutorial;
    }
}