namespace Maple2.Trigger._02100001_bf {
    public static class _407_mobspawn {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RemoveAll", value: 0);
                context.DestroyMonster(arg1: new[] {407});
            }

            public override void Execute() {
                if (context.GetUserCount() > 0) {
                    context.State = new StateMobSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn : TriggerState {
            internal StateMobSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {407}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {407})) {
                    context.State = new StateDelay01(context);
                    return;
                }

                if (context.GetUserValue(key: "RemoveAll") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 60000)) {
                    context.State = new StateMobSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {407});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}