namespace Maple2.Trigger._52010001_qd {
    public static class _main {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000871, 10000910}, arg2: 1);
                context.SetActor(arg1: 1001, arg2: true, arg3: "Down_Idle_A");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000871, 10000910}, arg2: 0)) {
                    context.State = new StateEvent_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "Firepotoff");
            }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1001, arg2: false, arg3: "Down_Idle_A");
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1001");
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52010001_QD__MAIN__0$", arg4: 3, arg5: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 702, arg2: new[] {101})) {
                    context.State = new StateEvent_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52010001_QD__MAIN__1$", arg4: 3, arg5: 0);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1002");
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new StateEvent_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_04 : TriggerState {
            internal StateEvent_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52010001_QD__MAIN__2$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000871}, arg2: 1);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1003");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 703, arg2: new[] {101})) {
                    context.State = new StateEvent_04_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_04_02 : TriggerState {
            internal StateEvent_04_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateEvent_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_05 : TriggerState {
            internal StateEvent_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1004");
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52010001_QD__MAIN__3$", arg4: 3, arg5: 0);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new StateEvent_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_06 : TriggerState {
            internal StateEvent_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52010001_QD__MAIN__4$", arg4: 3, arg5: 3);
                context.SetInteractObject(arg1: new[] {10000910}, arg2: 1);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1005");
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 704, arg2: new[] {101})) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1001, arg2: true, arg3: "Down_Idle_A");
                context.DestroyMonster(arg1: new[] {101});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}