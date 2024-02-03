using HarmonyLib;
using System.Security.Claims;
using TMPro;

namespace BannerUnitInfo
{
    [HarmonyPatch(typeof(CardFrameUI), nameof(CardFrameUI.SetTextContent))]
    public static class CardFrameUIPatch
    {
        [HarmonyPostfix]        
        private static void DisableFactionLabel(ref TMP_Text ___factionLabel)
        {
            ___factionLabel.gameObject.SetActive(false);
        }
    }
}
