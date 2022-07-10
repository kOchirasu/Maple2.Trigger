namespace Maple2.Trigger._80000015_bonus {
    public static class _skill_07 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{712, 726}, arg2: false);
                context.SetVisibleBreakableObject(triggerIds: new []{7701, 7702, 7703, 7704}, arg2: false);
                context.SetBreakable(triggerIds: new []{7701, 7702, 7703, 7704}, enabled: false);
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
                context.SetVisibleBreakableObject(triggerIds: new []{7701, 7702, 7703, 7704}, arg2: true);
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
                context.SetBreakable(triggerIds: new []{7701, 7702, 7703, 7704}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateActivateSkill(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivateSkill : TriggerState {
            internal StateActivateSkill(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{712, 726}, arg2: true);
                context.SetBreakable(triggerIds: new []{7701, 7702, 7703, 7704}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
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
