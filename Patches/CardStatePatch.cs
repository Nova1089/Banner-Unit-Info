using HarmonyLib;

namespace BannerUnitInfo
{
    [HarmonyPatch(typeof(CardState))]
    [HarmonyPatch("GetTitle")]
    public static class CardStatePatch
    {
        private static void Postfix(ref string __result)
        {
            if (__result == "Hornbreaker Prince")
            {
                __result = "Steve";
            }
        }
    }
}