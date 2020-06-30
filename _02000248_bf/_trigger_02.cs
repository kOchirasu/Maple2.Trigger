using System;

namespace Maple2.Trigger._02000248_bf {
    public static class _trigger_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateready(context);

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(IDs: new int[] {2101, 2102, 2103, 2104, 2105}, isVisible: "true");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Stateobjectset : TriggerState {
            internal Stateobjectset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(IDs: new int[] {2101, 2102, 2103, 2104, 2105}, randomCount: 1, isVisible: "true");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateWaitTick(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitTick : TriggerState {
            internal StateWaitTick(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateobjectset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}