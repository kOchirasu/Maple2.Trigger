namespace Maple2.Trigger._65000003_bd {
    public static class _cannon {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{104})) {
                    return new State대포Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대포Spawn : TriggerState {
            internal State대포Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{104})) {
                    return new State소환해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환해제 : TriggerState {
            internal State소환해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1001, 1002, 1003, 1004}, arg2: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
