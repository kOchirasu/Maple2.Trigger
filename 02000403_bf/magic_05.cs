namespace Maple2.Trigger._02000403_bf {
    public static class _magic_05 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000035}, arg2: 0)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7005}, visible: false);
                context.SetMesh(triggerIds: new []{1105}, visible: false, arg3: 0, arg4: 200, arg5: 15f);
                context.SetMesh(triggerIds: new []{1205}, visible: true, arg3: 0, arg4: 200, arg5: 15f);
                context.CreateMonster(spawnIds: new []{205}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{205})) {
                    return new StateEvent_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_05 : TriggerState {
            internal StateEvent_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 715, type: "trigger", code: "Hauntedmansion");
                context.CreateMonster(spawnIds: new []{145, 146, 147}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEvent_05_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_05_b : TriggerState {
            internal StateEvent_05_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 147, patrolName: "MS2PatrolData_2136");
                context.SetConversation(type: 1, spawnId: 147, script: "$02000403_BF__MAGIC_05__0$", arg4: 2, arg5: 2);
                context.SetConversation(type: 1, spawnId: 145, script: "$02000403_BF__MAGIC_05__1$", arg4: 3, arg5: 4);
                context.SetConversation(type: 1, spawnId: 146, script: "$02000403_BF__MAGIC_05__2$", arg4: 3, arg5: 5);
                context.SetConversation(type: 1, spawnId: 147, script: "$02000403_BF__MAGIC_05__3$", arg4: 3, arg5: 6);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEvent_05_c(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_05_c : TriggerState {
            internal StateEvent_05_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{148}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEvent_05_d(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_05_d : TriggerState {
            internal StateEvent_05_d(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 148, patrolName: "MS2PatrolData_2137");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_05_e(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_05_e : TriggerState {
            internal StateEvent_05_e(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{145, 146, 147});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_05_f(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_05_f : TriggerState {
            internal StateEvent_05_f(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{148});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
