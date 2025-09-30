using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace StormFlake;

// TODO Review this file and update to your own requirements.

[BepInPlugin(PluginGUID, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin {
    // Mod specific details
    private const string PluginGUID = "com.COTLMod.StormFlake";
    private const string PluginName = "StormFlake";
    private const string PluginVersion = "1.0.0";

    private static readonly Harmony Harmony = new(PluginGUID);
    public static ManualLogSource Log = new(PluginName);

    private void Awake() {
        // Apply and log plugin
        Logger.LogInfo($"PluginName: {PluginName}, VersionString: {PluginVersion} is loading...");
        Harmony.PatchAll();
        Logger.LogInfo($"PluginName: {PluginName}, VersionString: {PluginVersion} is loaded.");

        // Sets up our static Log, so it can be used elsewhere in code
        Log = Logger;
    }


    private void Update() { }

    private void OnDisable() {
        Harmony.UnpatchSelf();
        Logger.LogInfo($"Unloaded {PluginName}!");
    }
}