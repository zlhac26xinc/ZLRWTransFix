# ZL的翻译修复

Simple sidearms 自带汉化有问题，DefInjected/ConceptDef、DefInjected/JobDef 已修复，忽略以下错误：

```log
Found no RimWorld.ConceptDef named Concept_SidearmsInInventory to match Concept_SidearmsInInventory.label (Concepts.xml)
Found no RimWorld.ConceptDef named Concept_SidearmsInInventory to match Concept_SidearmsInInventory.helpText (Concepts.xml)
Found no RimWorld.ConceptDef named Concept_SidearmsPrimary to match Concept_SidearmsPrimary.label (Concepts.xml)
Found no RimWorld.ConceptDef named Concept_SidearmsPrimary to match Concept_SidearmsPrimary.helpText (Concepts.xml)
Found no RimWorld.ConceptDef named Concept_SimpleSidearmsAdvancd to match Concept_SimpleSidearmsAdvanced.label (Concepts.xml)
Found no RimWorld.ConceptDef named Concept_SimpleSidearmsAdvanced to match Concept_SimpleSidearmsAdvanced.helpText (Concepts.xml)
Found no RimWorld.ConceptDef named Concept_SimpleSidearmsDropping to match Concept_SimpleSidearmsDropping.label (Concepts.xml)
Found no RimWorld.ConceptDef named Concept_SimpleSidearmsDropping to match Concept_SimpleSidearmsDropping.helpText (Concepts.xml)
Found no Verse.JobDef named EquipSecondaryCombat to match EquipSecondaryCombat.reportString (Jobs_Misc.xml)
```

Mark That Pawn 的 Def 名应为 MarkThatPawn.MarkerDef，原 mod 少打了 MarkThatPawn 导致汉化未完全生效，DefInjected/MarkThatPawn.MarkerDef已修复，忽略以下错误：

```log
Error loading language from (D:\Steam\steamapps\workshop\content\294100\3056996662\Languages\ChineseSimplified, Mlie.MarkThatPawn, D:\Steam\steamapps\workshop\content\294100\3056996662): dir MarkerDef doesn't correspond to any def type. Skipping...
```

Character Editor 由 Character Editor Localization Extension 硬编码补丁翻译，无需修复，忽略以下问题：

```log
ThingDef: Zombrella.label '人物编辑舱'
ThingDef: Zombrella.description '舱式工业人形整形装置\n\n<i><color=#66E0E4FF>Character Editor</color></i>'
ThingDef: Blueprint_Install_Zombrella.label '人物编辑舱（蓝图）'
ThingDef: Blueprint_Zombrella.label '人物编辑舱（蓝图）'
ThingDef: Frame_Zombrella.label '人物编辑舱（建造中）'
ThingDef: Frame_Zombrella.description '舱式工业人形整形装置\n\n<i><color=#66E0E4FF>Character Editor</color></i>'
ThingDef: Zombgrella.label '人物编辑墓'
ThingDef: Zombgrella.description '墓式工业人形整形装置\n\n<i><color=#66E0E4FF>Character Editor</color></i>'
ThingDef: Blueprint_Zombgrella.label '人物编辑墓（蓝图）'
ThingDef: Frame_Zombgrella.label '人物编辑墓（建造中）'
ThingDef: Frame_Zombgrella.description '墓式工业人形整形装置\n\n<i><color=#66E0E4FF>Character Editor</color></i>'
```

Mod Options Sort 的按钮文本，Assemblies 已修复
先在 dnSpy 看清类型，别让 AI 猜

Bed Rest For Food Poisoning 作者名打错一个字母（或者是故意的？），直接在原模组 About.xml 修改了

Toggle Harvest 的按钮文本，Keyed 已修复

Numbers 原版自带汉化的按钮被Numbers 汉化改成了英文？MainButtonDef 已修复
