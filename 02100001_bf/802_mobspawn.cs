namespace Maple2.Trigger._02100001_bf {
    public static class _802_mobspawn {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RemoveAll", value: 0);
                context.DestroyMonster(spawnIds: new []{802});
                context.SetMesh(triggerIds: new []{3202}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateMobSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn : TriggerState {
            internal StateMobSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{802}, arg2: false);
                context.SetMesh(triggerIds: new []{3202}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{802})) {
                    return new StateDelay01(context);
                }

                if (context.GetUserValue(key: "RemoveAll") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3202}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 180000)) {
                    return new StateMobSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{802});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
