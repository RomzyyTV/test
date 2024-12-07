using MEC;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;

namespace Deathloop.Handler;
public class Server_Handler
{
    private CoroutineHandle _coroutine;
    
    [PluginEvent(ServerEventType.RoundStart)]
    private void OnRoundStart()
    {
        _coroutine = Timing.RunCoroutine(IEnumerator.AutoCassie());
        _coroutine = Timing.RunCoroutine(IEnumerator.ClearLag());
    }
    
    [PluginEvent(ServerEventType.RoundRestart)]
    private void RoundRestart()
    {
        Timing.KillCoroutines(_coroutine);
    }
}