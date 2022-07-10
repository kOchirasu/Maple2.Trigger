namespace Maple2.Trigger._02000403_bf {
    public static class _magic_04 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000034}, arg2: 0)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7004}, visible: false);
                context.SetMesh(triggerIds: new []{1104}, visible: false, arg3: 0, arg4: 200, arg5: 15f);
                context.SetMesh(triggerIds: new []{1204}, visible: true, arg3: 0, arg4: 200, arg5: 15f);
                context.CreateMonster(spawnIds: new []{204}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{204})) {
                    return new StateEvent_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_04 : TriggerState {
            internal StateEvent_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 714, type: "trigger", code: "Hauntedmansion");
                context.CreateMonster(spawnIds: new []{144}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEvent_04_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_04_b : TriggerState {
            internal StateEvent_04_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 144, script: "$02000403_BF__MAGIC_04__0$", arg4: 2, arg5: 2);
                context.SetConversation(type: 1, spawnId: 144, script: "$02000403_BF__MAGIC_04__1$", arg4: 4, arg5: 5);
                context.MoveNpc(spawnId: 144, patrolName: "MS2PatrolData_2134");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEvent_04_c(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_04_c : TriggerState {
            internal StateEvent_04_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 144, script: "$02000403_BF__MAGIC_04__2$", arg4: 3, arg5: 1);
                context.SetConversation(type: 1, spawnId: 144, script: "$02000403_BF__MAGIC_04__3$", arg4: 3, arg5: 4);
                context.MoveNpc(spawnId: 144, patrolName: "MS2PatrolData_2135");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEvent_04_d(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_04_d : TriggerState {
            internal StateEvent_04_d(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{144});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
