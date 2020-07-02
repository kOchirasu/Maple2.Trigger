namespace Maple2.Trigger._52000024_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {20002233}, arg3: new byte[] {1})) {
                    return new StateStart(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {20002233}, arg3: new byte[] {2})) {
                    return new StateStart(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {20002233}, arg3: new byte[] {3})) {
                    return new StateStart_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_B : TriggerState {
            internal StateStart_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {106, 101}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
                context.MoveUserPath(arg1: "MS2PatrolData_2101");
                context.CreateMonster(arg1: new[] {101, 102, 103}, arg2: false);
                context.CameraSelectPath(arg1: new[] {8001, 8002, 8003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7006}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001564, arg3: "$52000024_QD__MAIN__0$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {103});
                context.CreateMonster(arg1: new[] {104}, arg2: false);
            }
        }

        private class StateStart_05 : TriggerState {
            internal StateStart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
                context.CameraSelect(arg1: 8004, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartB_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }
        }

        private class StateStartB_01 : TriggerState {
            internal StateStartB_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 8005, arg2: true);
                context.MoveUser(arg1: 52000024, arg2: 99);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStartB_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartB_02 : TriggerState {
            internal StateStartB_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStartB_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartB_04 : TriggerState {
            internal StateStartB_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8005, 8006}, arg2: false);
                context.SetEffect(arg1: new[] {7003}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000024_QD__MAIN__1$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStartB_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartB_07 : TriggerState {
            internal StateStartB_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {105}, arg2: false);
                context.SetEffect(arg1: new[] {7001}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001570, arg3: "$52000024_QD__MAIN__2$", arg4: 7);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartB_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartB_08 : TriggerState {
            internal StateStartB_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8007, 8008}, arg2: false);
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_2006");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2005");
                context.MoveUserPath(arg1: "MS2PatrolData_2102");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateStartB_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartB_09 : TriggerState {
            internal StateStartB_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_2008");
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000024_QD__MAIN__3$", arg4: 5);
                context.SetEffect(arg1: new[] {7004}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStartB_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartB_10 : TriggerState {
            internal StateStartB_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001570, arg3: "$52000024_QD__MAIN__4$", arg4: 2);
                context.SetEffect(arg1: new[] {7002}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStartB_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartB_11 : TriggerState {
            internal StateStartB_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_2007");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStartB_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartB_12 : TriggerState {
            internal StateStartB_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {105});
                context.CameraSelect(arg1: 8005, arg2: false);
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "PirateRiddenSea");
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {20002233}, arg3: new byte[] {3})) {
                    return new StateStartC_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartC_01 : TriggerState {
            internal StateStartC_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$52000024_QD__MAIN__5$", arg4: 3, arg5: 0);
                context.SetEffect(arg1: new[] {7005}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStartC_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartC_02 : TriggerState {
            internal StateStartC_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2002");
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_2007");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStartC_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartC_03 : TriggerState {
            internal StateStartC_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {104});
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 701) == 1) {
                    return new StateStartD_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartD_01 : TriggerState {
            internal StateStartD_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}