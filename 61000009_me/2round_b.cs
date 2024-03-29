namespace Maple2.Trigger._61000009_me {
    public static class _2round_b {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "2Round_B") == 1) {
                    return new StateSpawn_Start_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawn_Start_Ready : TriggerState {
            internal StateSpawn_Start_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSpawn_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawn_Start : TriggerState {
            internal StateSpawn_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7103}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State2Round_Spawn_B_01_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_B_01_Ready : TriggerState {
            internal State2Round_Spawn_B_01_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7203}, visible: true);
                context.SetEffect(triggerIds: new []{7003}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    return new State2Round_Spawn_B_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_B_01 : TriggerState {
            internal State2Round_Spawn_B_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{103})) {
                    return new State2Round_Spawn_B_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_B_End : TriggerState {
            internal State2Round_Spawn_B_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_2007");
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__2ROUND_B__0$", arg4: 2, arg5: 1);
                context.SetUserValue(triggerId: 2037401, key: "2Round_B", value: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
