﻿// Project:         Daggerfall Tools For Unity
// Copyright:       Copyright (C) 2009-2018 Daggerfall Workshop
// Web Site:        http://www.dfworkshop.net
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Source Code:     https://github.com/Interkarma/daggerfall-unity
// Original Author: Gavin Clayton (interkarma@dfworkshop.net)
// Contributors:    
// 
// Notes:
//

using UnityEngine;
using DaggerfallConnect;
using DaggerfallWorkshop.Game.Entity;

namespace DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects
{
    /// <summary>
    /// Drain - Endurance
    /// </summary>
    public class DrainEndurance : DrainEffect
    {
        public override void SetProperties()
        {
            properties.Key = "Drain-Endurance";
            properties.ClassicKey = MakeClassicKey(7, 4);
            properties.GroupName = TextManager.Instance.GetText("ClassicEffects", "drain");
            properties.SubGroupName = TextManager.Instance.GetText("ClassicEffects", "endurance");
            properties.SpellMakerDescription = DaggerfallUnity.Instance.TextProvider.GetRSCTokens(1523);
            properties.SpellBookDescription = DaggerfallUnity.Instance.TextProvider.GetRSCTokens(1223);
            properties.SupportMagnitude = true;
            properties.ShowSpellIcon = false;
            properties.AllowedTargets = EntityEffectBroker.TargetFlags_Other;
            properties.AllowedElements = EntityEffectBroker.ElementFlags_All;
            properties.MagicSkill = DFCareer.MagicSkills.Destruction;
            properties.MagnitudeCosts = MakeEffectCosts(8, 100, 116);
            drainStat = DFCareer.Stats.Endurance;
        }
    }
}
