namespace Maple2.Trigger._80000015_bonus {
    public static class _skill_05 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{705, 727}, arg2: false);
                context.SetVisibleBreakableObject(triggerIds: new []{7501, 7502, 7503, 7504}, arg2: false);
                context.SetBreakable(triggerIds: new []{7501, 7502, 7503, 7504}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleBreakableObject(triggerIds: new []{7501, 7502, 7503, 7504}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{7501, 7502, 7503, 7504}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateActivateSkill(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivateSkill : TriggerState {
            internal StateActivateSkill(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{7501, 7502, 7503, 7504}, enabled: false);
                context.SetSkill(triggerIds: new []{705, 727}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
