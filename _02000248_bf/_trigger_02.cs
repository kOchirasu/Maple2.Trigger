namespace Maple2.Trigger._02000248_bf {
    public static class _trigger_02 {
        public class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(ids: new[] {2101, 2102, 2103, 2104, 2105}, isVisible: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class Stateobjectset : TriggerState {
            internal Stateobjectset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(ids: new[] {2101, 2102, 2103, 2104, 2105}, randomCount: 1, isVisible: true);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new Stateobjectset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}