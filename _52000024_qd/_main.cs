namespace Maple2.Trigger._52000024_qd {
    public static class _main {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {20002233},
                    arg3: new byte[] {1})) {
                    context.State = new Statestart(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {20002233},
                    arg3: new byte[] {2})) {
                    context.State = new Statestart(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {20002233},
                    arg3: new byte[] {3})) {
                    context.State = new Statestart_B(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_B : TriggerState {
            internal Statestart_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {106}, arg2: false);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.MoveUserPath(arg1: "MS2PatrolData_2101");
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.CreateMonster(arg1: new[] {103}, arg2: false);
                context.CameraSelectPath(arg1: new[] {8001, 8002, 8003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateStart_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateStart_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateStart_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7006}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001564, arg3: "$52000024_QD__MAIN__0$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateStart_05(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {103});
                context.CreateMonster(arg1: new[] {104}, arg2: false);
            }
        }

        private class StateStart_05 : TriggerState {
            internal StateStart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.CameraSelect(arg1: 8004, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatestartB_01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class StatestartB_01 : TriggerState {
            internal StatestartB_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 8005, arg2: true);
                context.MoveUser(arg1: 52000024, arg2: 99);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StatestartB_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatestartB_02 : TriggerState {
            internal StatestartB_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatestartB_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatestartB_04 : TriggerState {
            internal StatestartB_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8005, 8006}, arg2: false);
                context.SetEffect(arg1: new[] {7003}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000024_QD__MAIN__1$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StatestartB_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatestartB_07 : TriggerState {
            internal StatestartB_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {105}, arg2: false);
                context.SetEffect(arg1: new[] {7001}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001570, arg3: "$52000024_QD__MAIN__2$", arg4: 7);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatestartB_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatestartB_08 : TriggerState {
            internal StatestartB_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8007, 8008}, arg2: false);
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_2006");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2005");
                context.MoveUserPath(arg1: "MS2PatrolData_2102");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StatestartB_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatestartB_09 : TriggerState {
            internal StatestartB_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_2008");
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000024_QD__MAIN__3$", arg4: 5);
                context.SetEffect(arg1: new[] {7004}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StatestartB_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatestartB_10 : TriggerState {
            internal StatestartB_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001570, arg3: "$52000024_QD__MAIN__4$", arg4: 2);
                context.SetEffect(arg1: new[] {7002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatestartB_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatestartB_11 : TriggerState {
            internal StatestartB_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_2007");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatestartB_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatestartB_12 : TriggerState {
            internal StatestartB_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {105});
                context.CameraSelect(arg1: 8005, arg2: false);
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "PirateRiddenSea");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {20002233},
                    arg3: new byte[] {3})) {
                    context.State = new StatestartC_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatestartC_01 : TriggerState {
            internal StatestartC_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$52000024_QD__MAIN__5$", arg4: 3, arg5: 0);
                context.SetEffect(arg1: new[] {7005}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatestartC_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatestartC_02 : TriggerState {
            internal StatestartC_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2002");
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_2007");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatestartC_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatestartC_03 : TriggerState {
            internal StatestartC_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {104});
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 701) == 1) {
                    context.State = new StatestartD_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatestartD_01 : TriggerState {
            internal StatestartD_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}