using HarmonyLib;

namespace BannerUnitInfo
{
    [HarmonyPatch(typeof(CharacterData), nameof(CharacterData.GetName))]
    public static class NameSteveOnCharacter
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