namespace Maple2.Trigger._02100001_bf {
    public static class _600_mobspawn {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RemoveAll", value: 0);
                context.DestroyMonster(spawnIds: new []{600, 601, 602, 603, 604, 701, 702, 703, 704, 705});
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
                context.CreateMonster(spawnIds: new []{600, 601, 602, 603, 604, 701, 702, 703, 704, 705}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RemoveAll") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{600, 601, 602, 603, 604, 701, 702, 703, 704, 705});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
