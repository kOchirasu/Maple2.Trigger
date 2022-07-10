namespace Maple2.Trigger._52000045_qd {
    public static class _common_02 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 702, spawnIds: new []{301})) {
                    return new StateNpc_exit_01(context);
                }

                if (context.NpcDetected(boxId: 702, spawnIds: new []{302})) {
                    return new StateNpc_exit_02(context);
                }

                if (context.NpcDetected(boxId: 702, spawnIds: new []{303})) {
                    return new StateNpc_exit_03(context);
                }

                if (context.NpcDetected(boxId: 702, spawnIds: new []{304})) {
                    return new StateNpc_exit_04(context);
                }

                if (context.NpcDetected(boxId: 702, spawnIds: new []{305})) {
                    return new StateNpc_exit_05(context);
                }

                if (context.NpcDetected(boxId: 702, spawnIds: new []{306})) {
                    return new StateNpc_exit_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc_exit_01 : TriggerState {
            internal StateNpc_exit_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{301});
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
                context.DestroyMonster(spawnIds: new []{302});
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
                context.DestroyMonster(spawnIds: new []{303});
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
                context.DestroyMonster(spawnIds: new []{304});
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
                context.DestroyMonster(spawnIds: new []{305});
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
                context.DestroyMonster(spawnIds: new []{306});
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
