namespace Maple2.Trigger._52000045_qd {
    public static class _common {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 702, spawnIds: new []{201})) {
                    return new StateNpc_exit_01(context);
                }

                if (context.NpcDetected(boxId: 702, spawnIds: new []{202})) {
                    return new StateNpc_exit_02(context);
                }

                if (context.NpcDetected(boxId: 702, spawnIds: new []{203})) {
                    return new StateNpc_exit_03(context);
                }

                if (context.NpcDetected(boxId: 702, spawnIds: new []{204})) {
                    return new StateNpc_exit_04(context);
                }

                if (context.NpcDetected(boxId: 702, spawnIds: new []{205})) {
                    return new StateNpc_exit_05(context);
                }

                if (context.NpcDetected(boxId: 702, spawnIds: new []{206})) {
                    return new StateNpc_exit_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc_exit_01 : TriggerState {
            internal StateNpc_exit_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{201});
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
                context.DestroyMonster(spawnIds: new []{202});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc_exit_03 : TriggerState {
            internal StateNpc_exit_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{203});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc_exit_04 : TriggerState {
            internal StateNpc_exit_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{204});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc_exit_05 : TriggerState {
            internal StateNpc_exit_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{205});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc_exit_06 : TriggerState {
            internal StateNpc_exit_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{206});
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
