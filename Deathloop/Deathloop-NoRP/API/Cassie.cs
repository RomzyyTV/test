using NorthwoodLib.Pools;
using Respawning;

namespace Deathloop_NoRP.API;
public class Cassie
{
    public static void MessageTrasnlete(string message, string translation, bool IsHeld = false, bool isNoisy = false, bool isSubtitles = true)
    {
        var annoucement = StringBuilderPool.Shared.Rent();
        var cassies = message.Split('\n');
        var translations = translation.Split('\n');

        for (var i = 0; i < cassies.Length; i++)
            annoucement.Append($"{translations[i].Replace(' ', ' ')}<size=0> {cassies[i]} </size><split>");
            
        RespawnEffectsController.PlayCassieAnnouncement(annoucement.ToString(), IsHeld, isNoisy, isSubtitles);
        StringBuilderPool.Shared.Return(annoucement);
    }
}