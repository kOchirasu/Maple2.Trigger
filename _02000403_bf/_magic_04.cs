using System;

namespace Maple2.Trigger._02000403_bf {
    public static class _magic_04 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000034}, arg2: 0)) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7004}, arg2: false);
                context.SetMesh(arg1: new int[] {1104}, arg2: false, arg3: 0, arg4: 200, arg5: 15f);
                context.SetMesh(arg1: new int[] {1204}, arg2: true, arg3: 0, arg4: 200, arg5: 15f);
                context.CreateMonster(arg1: new int[] {204}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {204})) {
                    context.State = new StateEvent_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_04 : TriggerState {
            internal StateEvent_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 714, arg2: "trigger", arg3: "Hauntedmansion");
                context.CreateMonster(arg1: new int[] {144}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEvent_04_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_04_b : TriggerState {
            internal StateEvent_04_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 144, arg3: "$02000403_BF__MAGIC_04__0$", arg4: 2, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 144, arg3: "$02000403_BF__MAGIC_04__1$", arg4: 4, arg5: 5);
                context.MoveNpc(arg1: 144, arg2: "MS2PatrolData_2134");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateEvent_04_c(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_04_c : TriggerState {
            internal StateEvent_04_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 144, arg3: "$02000403_BF__MAGIC_04__2$", arg4: 3, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 144, arg3: "$02000403_BF__MAGIC_04__3$", arg4: 3, arg5: 4);
                context.MoveNpc(arg1: 144, arg2: "MS2PatrolData_2135");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateEvent_04_d(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_04_d : TriggerState {
            internal StateEvent_04_d(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {144});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}