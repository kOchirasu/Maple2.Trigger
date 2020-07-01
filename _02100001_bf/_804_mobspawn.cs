namespace Maple2.Trigger._02100001_bf {
    public static class _804_mobspawn {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RemoveAll", value: 0);
                context.DestroyMonster(arg1: new[] {804});
                context.SetMesh(arg1: new[] {3204}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.CreateMonster(arg1: new[] {804}, arg2: false);
                context.SetMesh(arg1: new[] {3204}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {804})) {
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

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3204}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 180000)) {
                    context.State = new StateMobSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {804});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}