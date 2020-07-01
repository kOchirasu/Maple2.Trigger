namespace Maple2.Trigger._02100001_bf {
    public static class _1217_flyaway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "FlyAway", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "FlyAway") == 1) {
                    context.State = new StateFlyAway(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFlyAway : TriggerState {
            internal StateFlyAway(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 217, arg2: 1217);
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
                context.DestroyMonster(arg1: new[] {1217});
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