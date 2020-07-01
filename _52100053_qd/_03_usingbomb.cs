namespace Maple2.Trigger._52100053_qd {
    public static class _03_usingbomb {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5100, 5101, 5102, 5103, 5200, 5201, 5202, 5203}, arg2: false);
                context.DestroyMonster(arg1: new[] {910, 911});
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9200})) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {910, 911}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateArrowGuideOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArrowGuideOn : TriggerState {
            internal StateArrowGuideOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039703, textId: 20039703, duration: 4000);
                context.SetEffect(arg1: new[] {5100, 5101, 5102, 5103, 5200, 5201, 5202, 5203}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9201})) {
                    return new StateArrowGuideOff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArrowGuideOff : TriggerState {
            internal StateArrowGuideOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5100, 5101, 5102, 5103, 5200, 5201, 5202, 5203}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}