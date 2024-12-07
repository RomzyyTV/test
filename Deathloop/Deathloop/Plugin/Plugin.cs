using System;
using Deathloop.Handler;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Events;

namespace Deathloop.Plugin;
public class Plugin
{
    [PluginEntryPoint("Deathloop", "1.0.0", "Plugin pour Deathloop", "RomzyyTV")]
    void Setup()
    {
        string romzyytv = @"
██████╗  ██████╗ ███╗   ███╗███████╗██╗   ██╗██╗   ██╗████████╗██╗   ██╗
██╔══██╗██╔═══██╗████╗ ████║╚══███╔╝╚██╗ ██╔╝╚██╗ ██╔╝╚══██╔══╝██║   ██║
██████╔╝██║   ██║██╔████╔██║  ███╔╝  ╚████╔╝  ╚████╔╝    ██║   ██║   ██║
██╔══██╗██║   ██║██║╚██╔╝██║ ███╔╝    ╚██╔╝    ╚██╔╝     ██║   ╚██╗ ██╔╝
██║  ██║╚██████╔╝██║ ╚═╝ ██║███████╗   ██║      ██║      ██║    ╚████╔╝ 
╚═╝  ╚═╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝   ╚═╝      ╚═╝      ╚═╝     ╚═══╝  ";
        Log.Info("==================================================");
        Log.Info(" Fait par RomzyyTV & Bankokwak ");
        Log.Info(" Fait pour Artica NoRP ");
        Log.Info("===========================================");
        Log.Info(">> Log in to our discord server: https://discord.gg/artica <<");
        API.Log.SendRaw(romzyytv, ConsoleColor.Green);
        EventManager.RegisterEvents<Map_Handler>(this);
        EventManager.RegisterEvents<Player_Handler>(this);
        EventManager.RegisterEvents<Server_Handler>(this);
    }
}