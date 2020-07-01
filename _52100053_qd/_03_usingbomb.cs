using System;

namespace Maple2.Trigger._52100053_qd {
    public static class _03_usingbomb {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5100, 5101, 5102, 5103}, arg2: false);
                context.SetEffect(arg1: new int[] {5200, 5201, 5202, 5203}, arg2: false);
                context.DestroyMonster(arg1: new int[] {910, 911});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9200})) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {910, 911}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateArrowGuideOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArrowGuideOn : TriggerState {
            internal StateArrowGuideOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20039703, textID: 20039703, duration: 4000);
                context.SetEffect(arg1: new int[] {5100, 5101, 5102, 5103}, arg2: true);
                context.SetEffect(arg1: new int[] {5200, 5201, 5202, 5203}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9201})) {
                    context.State = new StateArrowGuideOff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArrowGuideOff : TriggerState {
            internal StateArrowGuideOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5100, 5101, 5102, 5103}, arg2: false);
                context.SetEffect(arg1: new int[] {5200, 5201, 5202, 5203}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}