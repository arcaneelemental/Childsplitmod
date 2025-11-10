using System;
using System.Runtime.CompilerServices;
using System.Collections;
using ShinyShoe;

namespace Childsplit.Plugin
{
    class StatusEffectPurityState : StatusEffectState
    {
        public override bool TestTrigger(InputTriggerParams inputTriggerParams, OutputTriggerParams outputTriggerParams, ICoreGameManagers coreGameManagers)
        {
            CharacterState attacker = inputTriggerParams.attacker;
		    CharacterState attacked = inputTriggerParams.attacked;
		    if (attacked == null || !inputTriggerParams.attacked.IsPyreHeart() || inputTriggerParams.damage == 0)
		    {
		    	return false;
		    }
            outputTriggerParams.damage = 1;
		    return true;
        }

        protected override IEnumerator OnTriggered(InputTriggerParams inputTriggerParams, OutputTriggerParams outputTriggerParams, ICoreGameManagers coreGameManagers)
        {
            outputTriggerParams.damage = 1;
            yield break;
        }
    }
}