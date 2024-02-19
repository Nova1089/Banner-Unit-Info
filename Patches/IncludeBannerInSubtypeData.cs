using HarmonyLib;
using System.Collections.Generic;
using System.Text;

namespace BannerUnitInfo
{
    [HarmonyPatch(typeof(CharacterData), nameof(CharacterData.GetLocalizedSubtypes))]
    public static class IncludeBannerInSubtypeData
    {
        private static void Postfix(List<SubtypeData> subtypes, StringBuilder stringBuilder)
        {
            if (subtypes.Exists((SubtypeData s) => s.Key == "SubtypesData_Chosen") &&
               !subtypes.Exists((SubtypeData s) => s.IsChampion ))
            {
                stringBuilder.Append(" (B)");
            }
        }
    }
}