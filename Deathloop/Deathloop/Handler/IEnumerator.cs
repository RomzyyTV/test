using System.Collections.Generic;
using MEC;
using PlayerRoles.Ragdolls;
using PluginAPI.Core;
using UnityEngine;
using Cassie = Deathloop.API.Cassie;

namespace Deathloop.Handler;
public class IEnumerator
{
    public static IEnumerator<float> AutoCassie()
    {
        Cassie.MessageTrasnlete("Warning\n all personnel the game has now started good luck pitch_0.3 .g5 .g5 .g5 pitch_1.0", "Attention à tous le personnel\n La game vient de se lancer, bonne chance");
        Map.ChangeColorOfAllLights(Color.red);
        yield return Timing.WaitForSeconds(8f);
        Map.ResetColorOfAllLights();
        yield break;
    }
    public static IEnumerator<float> ClearLag()
    {
        for (;;)
        {
            yield return Timing.WaitForSeconds(600f);
            RagdollManager.AllRagdolls.Clear();
        }
    }
}