using BepInEx;
using HarmonyLib;
using HarmonyLib.Tools;

namespace BannerUnitInfo
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class Plugin : BaseUnityPlugin
    {
        public const string modGUID = "Nova.BannerUnitInfo";
        public const string modName = "Banner Unit Info";
        public const string modVersion = "1.0.0";

        public void Awake()
        {
            HarmonyFileLog.Enabled = true;
            Logger.LogInfo("This is info");
            Logger.LogWarning("This is a warning");
            Logger.LogError("This is an error");
            var harmony = new Harmony(modGUID);
            harmony.PatchAll();
            FileLog.Log("Harmony log test");
        }
    }
}
