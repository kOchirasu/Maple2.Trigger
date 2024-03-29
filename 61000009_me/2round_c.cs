namespace Maple2.Trigger._61000009_me {
    public static class _2round_c {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "2Round_C") == 1) {
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
                context.SetEffect(triggerIds: new []{7101}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State2Round_Spawn_C_01_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_C_01_Ready : TriggerState {
            internal State2Round_Spawn_C_01_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7201}, visible: true);
                context.SetEffect(triggerIds: new []{7001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    return new State2Round_Spawn_C_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_C_01 : TriggerState {
            internal State2Round_Spawn_C_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{104}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{104})) {
                    return new State2Round_Spawn_C_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_C_End : TriggerState {
            internal State2Round_Spawn_C_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_2008");
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__2ROUND_C__0$", arg4: 2, arg5: 1);
                context.SetUserValue(triggerId: 2037401, key: "2Round_C", value: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
