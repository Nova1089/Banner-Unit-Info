using HarmonyLib;
using TMPro;

namespace BannerUnitInfo
{
    [HarmonyPatch(typeof(CardFrameUI))]
    public static class CardFrameUIPatch
    {
        [HarmonyPostfix]
        [HarmonyPatch(nameof(CardFrameUI.SetTextContent))]
        private static void DisableFactionLabel(ref TMP_Text ___factionLabel)
        {
            ___factionLabel.gameObject.SetActive(false);
        }
    }
}