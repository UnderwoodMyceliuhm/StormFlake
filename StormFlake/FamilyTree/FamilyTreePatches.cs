using HarmonyLib;
using Lamb.UI;

namespace StormFlake.FamilyTree;

[HarmonyPatch]
internal static class FamilyTreePatches {
    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIFollowerSummaryMenuController), nameof(UIFollowerSummaryMenuController.Show))]
    private static void UIFollowerSummaryMenuController_Show(UIFollowerSummaryMenuController __instance) {
        
        /* Notes: 
         * __instance._follower is the follower we're inspecting
         * __instance._follower.Brain._directInfoAccess.Parents are follower's parents
         * __instance._follower.Brain._directInfoAccess.Siblings are the follower's siblings
         * since you can't see the follower's Children, you have to find them by looking for this follower in the other
         * follower's Parents. this needs to be done recursively to find grand and grand-grand children
         */
        
        // show genealogical tree
        __instance._infoBox._button.OnPointerEntered += () =>
        {
            // TODO
            Plugin.Log.LogInfo("MMButton on UIFollowerSummaryMenuController entered!");
        };
        
        // hide tree
        __instance._infoBox._button.OnPointerExited += () =>
        {
            // TODO
            Plugin.Log.LogInfo("MMButton on UIFollowerSummaryMenuController Exited!");
        };
    }
}