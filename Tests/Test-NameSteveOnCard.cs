using HarmonyLib;

namespace BannerUnitInfo
{
    // This patch is just for testing.

    /*
    [HarmonyPatch(typeof(CardState), nameof(CardState.GetTitle))]
    public static class Test-NameSteveOnCard
    {
        private static void Postfix(ref string __result)
        {
            if (__result == "Hornbreaker Prince")
            {
                __result = "Steve";
            }
        }
    }
    */
}