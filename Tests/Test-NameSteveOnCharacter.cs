using HarmonyLib;

namespace BannerUnitInfo
{
    // This patch is just for testing.

    /*
    [HarmonyPatch(typeof(CharacterData), nameof(CharacterData.GetName))]
    public static class Test-NameSteveOnCharacter
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