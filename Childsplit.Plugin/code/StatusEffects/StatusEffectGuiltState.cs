using System.Collections;
using ShinyShoe;

namespace Childsplit.Plugin
{
    class StatusEffectGuiltState : StatusEffectState
    {
        public override bool TestTrigger(InputTriggerParams inputTriggerParams, OutputTriggerParams outputTriggerParams, ICoreGameManagers coreGameManagers)
        {
            return inputTriggerParams.attacked != null && inputTriggerParams.attacked.IsPyreHeart() && inputTriggerParams.damage > 0;
        }

        protected override IEnumerator OnTriggered(InputTriggerParams inputTriggerParams, OutputTriggerParams outputTriggerParams, ICoreGameManagers coreGameManagers)
        {
            outputTriggerParams.damage = 1;
            yield break;
        }
    }
}