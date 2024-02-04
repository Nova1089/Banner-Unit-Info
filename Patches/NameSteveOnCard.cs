using HarmonyLib;

namespace BannerUnitInfo
{
    [HarmonyPatch(typeof(CardState), nameof(CardState.GetTitle))]
    public static class NameSteveOnCard
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