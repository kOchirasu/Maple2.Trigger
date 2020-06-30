using System;

namespace Maple2.Trigger._02100001_bf {
    public static class _1218_flyaway {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "FlyAway", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "FlyAway", value: 1)) {
                    context.State = new StateFlyAway(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFlyAway : TriggerState {
            internal StateFlyAway(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 218, arg2: 1218);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1218});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}