using HarmonyLib;

namespace BannerUnitInfo
{
    [HarmonyPatch(typeof(CharacterData))]
    [HarmonyPatch("GetName")]
    public static class CharacterDataPatch
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