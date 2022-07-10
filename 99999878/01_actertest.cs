namespace Maple2.Trigger._99999878 {
    public static class _01_actertest {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 1000, visible: true, initialSequence: "Closed");
                context.SetBreakable(triggerIds: new []{2000}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{2000}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateOpenDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpenDelay : TriggerState {
            internal StateOpenDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateOpen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpen : TriggerState {
            internal StateOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 1000, visible: true, initialSequence: "Opened");
                context.SetBreakable(triggerIds: new []{2000}, enabled: true);
                context.SetVisibleBreakableObject(triggerIds: new []{2000}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateOffDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOffDelay : TriggerState {
            internal StateOffDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateOff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOff : TriggerState {
            internal StateOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 1000, visible: false, initialSequence: "Opened");
                context.SetBreakable(triggerIds: new []{2000}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{2000}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
