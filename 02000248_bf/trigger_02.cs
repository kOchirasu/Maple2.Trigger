namespace Maple2.Trigger._02000248_bf {
    public static class _trigger_02 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(triggerIds: new []{2101, 2102, 2103, 2104, 2105}, visible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateObjectset : TriggerState {
            internal StateObjectset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(triggerIds: new []{2101, 2102, 2103, 2104, 2105}, randomCount: 1, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateWaitTick(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTick : TriggerState {
            internal StateWaitTick(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateObjectset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
