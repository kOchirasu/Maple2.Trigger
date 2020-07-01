namespace Maple2.Trigger._02100001_bf {
    public static class _1216_flyaway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "FlyAway", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "FlyAway") == 1) {
                    return new StateFlyAway(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFlyAway : TriggerState {
            internal StateFlyAway(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 216, arg2: 1216);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1216});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}