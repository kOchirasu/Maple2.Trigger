namespace Maple2.Trigger._52000025_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202}, arg2: false);
                context.SetEffect(arg1: new[] {7001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {20002235}, arg3: new byte[] {1}, arg4: 90)) {
                    return new StateStart(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {20002235}, arg3: new byte[] {2}, arg4: 90)) {
                    return new StateStart_B(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {20002235}, arg3: new byte[] {3}, arg4: 90)) {
                    return new StateStart_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_B : TriggerState {
            internal StateStart_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202, 299}, arg2: false);
                context.DestroyMonster(arg1: new[] {203, 204, 205});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201, 203, 204, 101, 102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101, 102})) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$52000025_QD__MAIN__0$", arg4: 2, arg5: 1);
            }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111, 112, 113, 114, 115, 116}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$52000025_QD__MAIN__1$", arg4: 2, arg5: 5);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {111, 112, 113, 114, 115, 116})) {
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000025_QD__MAIN__2$", arg4: 4);
                context.SetEffect(arg1: new[] {7001}, arg2: true);
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
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2000");
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000025_QD__MAIN__3$", arg4: 6);
                context.SetEffect(arg1: new[] {7004}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateStart_05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 4);
            }
        }

        private class StateStart_05 : TriggerState {
            internal StateStart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {203, 204, 205});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_06(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
                context.MoveUser(arg1: 52000025, arg2: 99);
            }
        }

        private class StateStart_06 : TriggerState {
            internal StateStart_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2001");
                context.MoveUserPath(arg1: "MS2PatrolData_2002");
                context.CameraSelectPath(arg1: new[] {8001, 8002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_07 : TriggerState {
            internal StateStart_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001575, arg3: "$52000025_QD__MAIN__4$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_08 : TriggerState {
            internal StateStart_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000025_QD__MAIN__5$", arg4: 5);
                context.SetEffect(arg1: new[] {7002}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateStart_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_09 : TriggerState {
            internal StateStart_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001575, arg3: "$52000025_QD__MAIN__6$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_10 : TriggerState {
            internal StateStart_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001575, arg3: "$52000025_QD__MAIN__7$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_11(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelect(arg1: 8001, arg2: false);
            }
        }

        private class StateStart_11 : TriggerState {
            internal StateStart_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {299}, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "SweepthePriates");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}