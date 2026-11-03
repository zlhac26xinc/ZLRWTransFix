using System;
using UnityEngine;
using HarmonyLib;
using Verse;

namespace ModOptionsSort_Chinese
{
    // 这个特性让游戏启动时自动执行静态构造函数，从而应用补丁
    [StaticConstructorOnStartup]
    public static class HarmonyInit
    {
        static HarmonyInit()
        {
            // 创建一个唯一的Harmony实例ID，格式建议为 "作者名.模组名.用途"
            var harmony = new Harmony("zl.ModOptionsSort.zh");
            harmony.PatchAll(); // 自动扫描并应用当前程序集中所有[HarmonyPatch]补丁
            Log.Message("[zl_ModOptionsSort_Chinese] Harmony patches applied.");
        }
    }

    [HarmonyPatch(typeof(Widgets), "ButtonText", new Type[]{typeof(Rect), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(TextAnchor?)})]
    public static class Patch_Widgets_ButtonText
    {
        static void Prefix(ref string label)
        {
            if (label == "Sorting by Author") label = "按作者排序";
            else if (label == "Sorting by Name") label = "按名称排序";
            else if (label == "Grouping Various") label = "分组杂项";
            else if (label == "Not Grouping Various") label = "不分组杂项";
        }
    }
}
