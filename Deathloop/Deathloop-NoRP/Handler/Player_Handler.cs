using CustomPlayerEffects;
using PlayerRoles;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using PluginAPI.Events;

namespace Deathloop_NoRP.Handler;
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

    [PluginEvent(ServerEventType.PlayerDying)]
    private static void OnPlayerDying(PlayerDyingEvent ev)
    {
        if (ev.Attacker != null)
        {
            ev.Attacker.ReceiveHint($"<b>Tu as tué <color=red>{ev.Player.Nickname}</color></b>", 5f);
            ev.Player.ReceiveHint($"<b>Tu est mort par <color=red>{ev.Attacker.Nickname}</color></b>", 5f);
            ev.Attacker.Health = UnityEngine.Random.Range(0f, 25f);
            return;
        }
        else
        {
            ev.Player.ReceiveHint("Tu est mort par une force <color=red>inconnue</color>", 5f);
        }
    }
    
    [PluginEvent(ServerEventType.Scp096AddingTarget)]
    private static void OnAddingTarget(Scp096AddingTargetEvent ev)
    {
        ev.Target.ReceiveHint("<b>Vous avez regardé SCP-096</b>", duration: 5f);
    }
}