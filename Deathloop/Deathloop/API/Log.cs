using System;

namespace Deathloop.API;
public class Log
{
    public static void SendRaw(object message, ConsoleColor color) => ServerConsole.AddLog(message.ToString(), color);
    public static void SendRaw(string message, ConsoleColor color) => ServerConsole.AddLog(message, color);

    public static void Send(object message, Discord.LogLevel level, ConsoleColor color = ConsoleColor.Gray)
    {
        SendRaw($"[{level.ToString().ToUpper()}] {message}", color);
    }

    public static void Send(string message, Discord.LogLevel level, ConsoleColor color = ConsoleColor.Gray)
    {
        SendRaw($"[{level.ToString().ToUpper()}] {message}", color);
    }
}