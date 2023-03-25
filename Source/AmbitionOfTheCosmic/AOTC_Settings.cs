using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;
using HugsLib.Settings;
using HugsLib;

namespace AOTC_Settings
{
    public class AOTC_Settings : ModBase
    {
        /* 
        plans of desired functionality for [Have It Your Way]:
        
        1. Boolean toggle, which turns on or off everything related to the toggle.
       
        2. Enumerator Button toggle, which turns on everything that says it needs the button to work. Something can accept several button options, preferably in <li>.
            EX: Option1, Option2, Option3 are options. Option2 is selected. Thing will exist if Option1 /or/ Option2 are selected.
            EX: Option1, Option2, Option3 are options. Option1 is selected. Thing will exist /only if/ Option1 is selected.
        */

        /* 
        AOTC Settings:
            [Generation Limit]
            1: Highest Unlockable Generation          - The highest generation that can be researched into and crafted/built.
            2: Highest General Spawning Generation    - The highest generation that will have items randomly spawn. Doesn't include materials.
            3: Highest Material Spawning Generation   - The highest generation of crafting materials (ex: Starsteel, Cosmic Alloy, Zenith Alloy)

            [Content Categories]
            1. 

            [Optional Modules]
            1. 
        */

        public override string ModIdentifier
        {
            get { return "AmbitionOfTheCosmic"; }
        }
        
        private enum AOTC_Generations { Gen1, Gen2, Gen3, Gen4, Gen5, Gen6, Gen7 }
        public override void DefsLoaded()
        {
            var AOTC_HighUnlockGen = Settings.GetHandle("AOTC_HighUnlockGen",
                "AOTC_HighUnlockGen_Title".Translate(),
                "AOTC_HighUnlockGen_Desc".Translate(),
                AOTC_Generations.Gen7,
                null, "AOTC_HighUnlockGen_");

            var AOTC_HighGeneralSpawnGen = Settings.GetHandle("AOTC_HighGeneralSpawnGen",
                "AOTC_HighGeneralSpawnGen_Title".Translate(),
                "AOTC_HighGeneralSpawnGen_Desc".Translate(),
                AOTC_Generations.Gen7,
                null, "AOTC_HighGeneralSpawnGen_");

            var AOTC_HighMaterialSpawnGen = Settings.GetHandle("AOTC_HighMaterialSpawnGen",
                "AOTC_HighMaterialSpawnGen_Title".Translate(),
                "AOTC_HighMaterialSpawnGen_Desc".Translate(),
                AOTC_Generations.Gen7,
                null, "AOTC_HighMaterialSpawnGen_");
        }
    }
}
