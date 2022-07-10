namespace Maple2.Trigger._52000050_qd {
    public static class _common {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 702, spawnIds: new []{121})) {
                    return new StateNpc_exit_01(context);
                }

                if (context.NpcDetected(boxId: 702, spawnIds: new []{122})) {
                    return new StateNpc_exit_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc_exit_01 : TriggerState {
            internal StateNpc_exit_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{121});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc_exit_02 : TriggerState {
            internal StateNpc_exit_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{122});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
