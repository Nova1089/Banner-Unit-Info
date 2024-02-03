using HarmonyLib;
using TMPro;

namespace BannerUnitInfo
{
    [HarmonyPatch(typeof(CardFrameUI))]
    public static class CardFrameUIPatch
    {
        [HarmonyPostfix]
        [HarmonyPatch(nameof(CardFrameUI.SetTextContent))]
        private static void DisableFactionLabel(TMP_Text factionLabel)
        {
            factionLabel.gameObject.SetActive(false);
        }
    }
}