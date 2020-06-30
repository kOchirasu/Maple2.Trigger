using System;

namespace Maple2.Trigger._52010020_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7001}, arg2: false);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 4);
                context.CreateMonster(arg1: new int[] {101, 102});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "701")) {
                    context.State = new StateEvent_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_Ready : TriggerState {
            internal StateEvent_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new StateEvent_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2001");
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52010020_QD__MAIN__0$", arg4: 5);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new StateEvent_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2002");
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52010020_QD__MAIN__1$", arg4: 5);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new StateEvent_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7001}, arg2: true);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2004");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2001");
                context.MoveUser(arg1: 52010020, arg2: 1, arg3: 701);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.CreateMonster(arg1: new int[] {103});
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_2003");
                context.CameraSelectPath(arg1: new int[] {8001, 8002}, arg2: 0);
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new StateEvent_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_04 : TriggerState {
            internal StateEvent_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001502, arg3: "$52010020_QD__MAIN__2$", arg4: 4);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2001");
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new StateEvent_05(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 4);
            }
        }

        private class StateEvent_05 : TriggerState {
            internal StateEvent_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "luanDialogue");
                context.CameraSelect(arg1: 8001, arg2: false);
                context.MoveUser(arg1: 52010019, arg2: 2, arg3: 701);
            }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}