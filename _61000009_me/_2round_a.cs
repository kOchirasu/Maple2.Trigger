using System;

namespace Maple2.Trigger._61000009_me {
    public static class _2round_a {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "2Round_A", value: 1)) {
                    context.State = new StateSpawn_Start_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSpawn_Start_Ready : TriggerState {
            internal StateSpawn_Start_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSpawn_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSpawn_Start : TriggerState {
            internal StateSpawn_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7102}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State2Round_Spawn_A_01_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_A_01_Ready : TriggerState {
            internal State2Round_Spawn_A_01_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7202}, arg2: true);
                context.SetEffect(arg1: new int[] {7002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    context.State = new State2Round_Spawn_A_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_A_01 : TriggerState {
            internal State2Round_Spawn_A_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {102})) {
                    context.State = new State2Round_Spawn_A_End(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_A_End : TriggerState {
            internal State2Round_Spawn_A_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_2006");
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__2ROUND_A__0$", arg4: 2, arg5: 1);
                context.SetUserValue(triggerID: 2037401, key: "2Round_A", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}