using System;

namespace Maple2.Trigger._52000025_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {202}, arg2: false);
                context.SetEffect(arg1: new int[] {7001}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {20002235}, arg3: new byte[] {1},
                    arg4: 90)) {
                    context.State = new Statestart(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {20002235}, arg3: new byte[] {2},
                    arg4: 90)) {
                    context.State = new Statestart_B(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {20002235}, arg3: new byte[] {3},
                    arg4: 90)) {
                    context.State = new Statestart_B(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_B : TriggerState {
            internal Statestart_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {202, 299}, arg2: false);
                context.DestroyMonster(arg1: new int[] {203, 204, 205});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {201, 203, 204}, arg2: false);
                context.CreateMonster(arg1: new int[] {101, 102}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101, 102})) {
                    context.State = new Statestart_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$52000025_QD__MAIN__0$", arg4: 2, arg5: 1);
            }
        }

        private class Statestart_02 : TriggerState {
            internal Statestart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {111, 112, 113, 114, 115, 116}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$52000025_QD__MAIN__1$", arg4: 2, arg5: 5);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {111, 112, 113, 114, 115, 116})) {
                    context.State = new Statestart_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_03 : TriggerState {
            internal Statestart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000025_QD__MAIN__2$", arg4: 4);
                context.SetEffect(arg1: new int[] {7001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statestart_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_04 : TriggerState {
            internal Statestart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2000");
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000025_QD__MAIN__3$", arg4: 6);
                context.SetEffect(arg1: new int[] {7004}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new Statestart_05(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 4);
            }
        }

        private class Statestart_05 : TriggerState {
            internal Statestart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {203, 204, 205});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateStart_06(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.MoveUser(arg1: 52000025, arg2: 99);
            }
        }

        private class StateStart_06 : TriggerState {
            internal StateStart_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2001");
                context.MoveUserPath(arg1: "MS2PatrolData_2002");
                context.CameraSelectPath(arg1: new int[] {8001, 8002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateStart_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStart_07 : TriggerState {
            internal StateStart_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001575, arg3: "$52000025_QD__MAIN__4$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateStart_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStart_08 : TriggerState {
            internal StateStart_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000025_QD__MAIN__5$", arg4: 5);
                context.SetEffect(arg1: new int[] {7002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateStart_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStart_09 : TriggerState {
            internal StateStart_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001575, arg3: "$52000025_QD__MAIN__6$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateStart_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStart_10 : TriggerState {
            internal StateStart_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001575, arg3: "$52000025_QD__MAIN__7$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateStart_11(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CameraSelect(arg1: 8001, arg2: false);
            }
        }

        private class StateStart_11 : TriggerState {
            internal StateStart_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {201});
                context.CreateMonster(arg1: new int[] {299}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "SweepthePriates");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}