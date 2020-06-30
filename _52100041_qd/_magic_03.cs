using System;

namespace Maple2.Trigger._52100041_qd {
    public static class _magic_03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002074}, arg2: 0)) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7003}, arg2: false);
                context.SetMesh(arg1: new int[] {1103}, arg2: false, arg3: 0, arg4: 200, arg5: 15f);
                context.SetMesh(arg1: new int[] {1203}, arg2: true, arg3: 0, arg4: 200, arg5: 15f);
                context.CreateMonster(arg1: new int[] {203}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {203})) {
                    context.State = new StateEvent_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {165, 166, 167, 168, 169}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 165, arg2: "Down_Idle_A", arg3: 600000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEvent_03_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_03_b : TriggerState {
            internal StateEvent_03_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 168, arg2: "MS2PatrolData_2138");
                context.SetNpcEmotionLoop(arg1: 165, arg2: "Down_Idle_A", arg3: 600000f);
                context.SetConversation(arg1: 1, arg2: 165, arg3: "$52100041_QD__MAGIC_03__0$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 169, arg3: "$52100041_QD__MAGIC_03__1$", arg4: 3, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 168, arg3: "$52100041_QD__MAGIC_03__2$", arg4: 3, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 168, arg3: "$52100041_QD__MAGIC_03__3$", arg4: 3, arg5: 6);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    context.State = new StateEvent_03_c(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_03_c : TriggerState {
            internal StateEvent_03_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {165, 166, 167, 168, 169});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}